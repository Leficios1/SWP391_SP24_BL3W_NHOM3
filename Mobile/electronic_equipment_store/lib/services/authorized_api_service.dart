import 'dart:convert';

import 'package:electronic_equipment_store/core/constants/config_constans.dart';
import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:hive/hive.dart';
import 'package:http/http.dart' as http;

class AuthorizedApiService {
  static String getToken() {
    var tokenBox = Hive.box('tokenBox');
    String? token = tokenBox.get('token');
    if (token != null) {
      return token;
    } else {
      // ignore: avoid_print
      print('Không tìm thấy token trong box.');
      return "";
    }
  }  


  static Future updateQuantityProductInCart(int userID, int productID, int quantityUserWantBuy)async{
    final url = Uri.parse('$apiLink/api/Cart/update-quantity-by-productid-and-userid/$userID/$productID/$quantityUserWantBuy');
    final response = await http.put(
      url,
      headers: {
        'accept': '*/*',
        "Authorization": "Bearer ${getToken()}",
      },
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return null;
    }
  }

  static Future addProductToCart(
      int userID, int productID, int quantityUserWantBuy) async {
    final url = Uri.parse('$apiLink/api/Cart/add-product-into-cart');
    final response = await http.post(
      url,
      headers: {
        'accept': '*/*',
        'Content-Type': 'application/json',
        "Authorization": "Bearer ${getToken()}",
      },
      body: jsonEncode({
        'productId': productID,
        'quantity': quantityUserWantBuy,
        'userId': userID
      }),
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return null;
    }
  }

  static Future deleteProductFromCart(int userId, int productId) async {
  final url = Uri.parse('$apiLink/api/Cart/delete-product-id-by-user-id/$productId/$userId');
  final response = await http.delete(
      url,
      headers: <String, String>{
        'Authorization': 'Bearer ${getToken()}',
        'accept': '*/*',
      },
    );
    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return null;
    }
  }

  static Future<List<ProductModel>?> getCartByUserID(int userID) async {
  final url = Uri.parse('$apiLink/api/Cart/get-by-user-id/$userID');
  try {
    final response = await http.get(url,
        headers: <String, String>{
        'Authorization': 'Bearer ${getToken()}',
        'accept': '*/*', 
      },);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> productList = jsonResponse['data'];
        List<ProductModel> products = productList.map((json) => ProductModel.fromJsonGetCartByUserID(json)).toList();        
        return products;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load getCartByUserID');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
}
}
