import 'dart:convert';
import 'package:electronic_equipment_store/core/constants/config_constans.dart';
import 'package:electronic_equipment_store/models/category_model.dart';
import 'package:electronic_equipment_store/models/feedback_model.dart';
import 'package:electronic_equipment_store/models/product_detail_model.dart';
import 'package:electronic_equipment_store/models/product_image_model.dart';
import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:electronic_equipment_store/models/user_model.dart';
import 'package:http/http.dart' as http;

class ApiService {
//Not Authorize
  static Future<Map<String, dynamic>?> logIn(
      String email, String password) async {
    final url = Uri.parse('$apiLink/api/Auth/login');
    final response = await http.post(
      url,
      headers: {
        'accept': '*/*',
        'Content-Type': 'application/json',
      },
      body: jsonEncode({'email': email, 'password': password}),
    );

    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return null;
    }
  }

  static Future<Map<String, dynamic>?> getUserByToken(String token) async {
    final url = Uri.parse('$apiLink/api/Auth/login/get-user-by-token/$token');
    final response = await http.get(url, headers: {
      'accept': '*/*',
      'Content-Type': 'application/json',
    });

    if (response.statusCode == 200) {
      return json.decode(response.body);
    } else {
      return null;
    }
  }

  static Future<List<CategoryModel>?> getAllCategory() async {
    final url = Uri.parse('$apiLink/api/Category/getall');
    try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> categoryList = jsonResponse['data'];
        List<CategoryModel> categories = categoryList.map((json) => CategoryModel.fromJson(json)).toList();        
        return categories;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load all Category');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
  }


  static Future<List<ProductModel>?> getAllProduct() async {
  final url = Uri.parse('$apiLink/api/Product/getAll');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> productList = jsonResponse['data']['products'];
        List<ProductModel> products = productList.map((json) => ProductModel.fromJson(json)).toList();        
        return products;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load all Product');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
}

  static Future<ProductModel> getProductByID(int productID) async {
  final url = Uri.parse('$apiLink/api/Product/getDetailsById/$productID');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> data = json.decode(response.body);
      Map<String, dynamic> productData = data['data']['products'];
      ProductModel productModel = ProductModel.fromJsonGetByID(productData);
      return productModel;
    } else {
      throw Exception('Failed to load product detail');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
}

  
  

  static Future<List<ProductModel>?> getAllProductByCategoryID(int categoryId) async {
  final url = Uri.parse('$apiLink/api/Category/get-product-by-category/$categoryId');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> productList = jsonResponse['data']['products'];
        List<ProductModel> products = productList.map((json) => ProductModel.fromJson(json)).toList();        
        return products;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load Product by Category');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
}
  static Future<List<ProductModel>?> getAllProductByProductName(String productName) async {
  final url = Uri.parse('$apiLink/api/Product/search?name=$productName');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> productList = jsonResponse['data']['products'];
        List<ProductModel> products = productList.map((json) => ProductModel.fromJson(json)).toList();        
        return products;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load all Product by product name');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
}
  static Future<List<ProductImageModel>> getAllProductImgByProductID(
      int productID) async {
    final url = Uri.parse('$apiLink/api/Product/getDetailsById/$productID');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> imageList = jsonResponse['data']['images'];
        List<ProductImageModel> images = imageList.map((json) => ProductImageModel.fromJson(json)).toList();        
        return images;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load all getAllProductImgByProductID');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
  }

  static Future<List<ProductDetailModel>> getListProductDetailByProductByID(int productId) async {
    final url = Uri.parse('$apiLink/api/Product/getDetailsById/$productId');
  try {
    final response = await http.get(url);
    if (response.statusCode == 200) {
      Map<String, dynamic> jsonResponse = json.decode(response.body);
      if (jsonResponse.containsKey('data')) {
        List<dynamic> productDetailList = jsonResponse['data']['details'];
        List<ProductDetailModel> images = productDetailList.map((json) => ProductDetailModel.fromJson(json)).toList();        
        return images;
      } else {
        throw Exception('Invalid JSON format: "data" field not found');
      }
    } else {
      throw Exception('Failed to load all getAllProductImgByProductID');
    }
  } catch (e) {
    throw Exception('Error: $e');
  }
  }

  // static Future<List<ProductModel>?> getAllProductOnAvailable() async {
  //   try {
  //     List<ProductModel> products = [
  //       ProductModel(
  //           productID: 001,
  //           productName: "Bếp từ 01",
  //           productDecription: "Bếp dùng điện để tạo ra từ",
  //           quantity: 8,
  //           productImage:
  //               "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s",
  //           price: 100000000,
  //           warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0),
  //           categories: <CategoryModel>[
  //             CategoryModel(categoryID: 001, categoryName: "đồ điẹn")
  //           ]),
  //       ProductModel(
  //           productID: 001,
  //           productName: "Bếp từ 02",
  //           productDecription: "Bếp dùng điện để tạo ra từ",
  //           quantity: 8,
  //           productImage:
  //               "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s",
  //           price: 1000000000,
  //           warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0),
  //           categories: <CategoryModel>[
  //             CategoryModel(categoryID: 001, categoryName: "đồ điẹn")
  //           ]),
  //     ];
  //     return products;
  //   } catch (e) {
  //     throw Exception('Error: $e');
  //   }
  // }

  static Future<List<FeedbackModel>> getFeedbackByProductID(
      int productID) async {
    try {
      List<FeedbackModel> feedbacks = [
        FeedbackModel(
            feedBackID: 1,
            ratingPoint: 3,
            description: 'tạm được',
            createdDate: DateTime(2024, 4, 14, 12, 30, 0),
            userModel: UserModel(
                userID: 001,
                name: "Trần Văn Phê",
                email: "email",
                roleId: 2,
                status: true)),
        FeedbackModel(
            feedBackID: 1,
            ratingPoint: 5,
            description: 'xịn đêý',
            createdDate: DateTime(2024, 4, 14, 12, 30, 0),
            userModel: UserModel(
                userID: 002,
                name: "Nguyễn Văn Pha",
                email: "email",
                roleId: 2,
                status: true))
      ];
      return feedbacks;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  
}
