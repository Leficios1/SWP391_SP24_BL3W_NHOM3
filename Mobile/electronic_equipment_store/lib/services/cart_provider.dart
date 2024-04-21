import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:electronic_equipment_store/services/auth_provider.dart';
import 'package:electronic_equipment_store/services/authorized_api_service.dart';
import 'package:flutter/material.dart';

class CartProvider with ChangeNotifier {
  List<ProductModel> _cartItems = [];
  List<ProductModel> get cartItems => _cartItems;


  void fetchCart() async{
    List<ProductModel>? listProduct = await AuthorizedApiService.getCartByUserID(AuthProvider.userModel!.userID);
    if (listProduct != null) {
      _cartItems = listProduct;
    }
    notifyListeners();
  }

  void removeProductFromCart(ProductModel product) {
    // Thêm dữ liệu xuông BE
    AuthorizedApiService.deleteProductFromCart(AuthProvider.userModel!.userID, product.productID);
    //------------------------
    _cartItems.remove(product);
    notifyListeners();
  }

  void addToCart(ProductModel product, int quantityUserWantBy) {
    if(AuthProvider.userModel != null){
    // Thêm dữ liệu xuông BE
    AuthorizedApiService.addProductToCart(AuthProvider.userModel!.userID, product.productID, quantityUserWantBy);
    //------------------------
    product.quantityUserWantBuy = quantityUserWantBy;
    _cartItems.add(product);
    notifyListeners();
    }
  }

  void addQuantityProductInCart(ProductModel product, int quantityUserWantBy) {
    if(AuthProvider.userModel != null){
    // Thêm dữ liệu xuông BE
    AuthorizedApiService.addProductToCart(AuthProvider.userModel!.userID, product.productID, quantityUserWantBy);
    //------------------------
    for (int i = 0; i < _cartItems.length; i++) {
      if (_cartItems[i].productID == product.productID) {
        _cartItems[i].quantityUserWantBuy = cartItems[i].quantityUserWantBuy! + quantityUserWantBy;
        break;
      }
    }
    notifyListeners();
    }
  }
  void updateQuantityProductInCart(ProductModel product, int quantityUserWantBy) {
    if(AuthProvider.userModel != null){
    // Thêm dữ liệu xuông BE
    AuthorizedApiService.updateQuantityProductInCart(AuthProvider.userModel!.userID, product.productID, quantityUserWantBy);
    //------------------------
    for (int i = 0; i < _cartItems.length; i++) {
      if (_cartItems[i].productID == product.productID) {
        _cartItems[i].quantityUserWantBuy = quantityUserWantBy;
        break;
      }
    }
    notifyListeners();
    }
  }


  bool isProductInCart(int productId) {
    return _cartItems.any((item) => item.productID == productId);
  }

  void clearCart() {
    _cartItems.clear();
    notifyListeners();
  }
}
