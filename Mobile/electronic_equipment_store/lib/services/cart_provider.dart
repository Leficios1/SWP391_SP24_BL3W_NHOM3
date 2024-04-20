import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:flutter/material.dart';

class CartProvider with ChangeNotifier {
  List<ProductModel> _cartItems = [];
  List<ProductModel> get cartItems => _cartItems;

  void removeFromCartAndCheckOut() {
    _cartItems.clear();

    notifyListeners();
  }

  void removeProductFromCart(ProductModel product) {
    _cartItems.remove(product);
    notifyListeners();
  }

  void addToCart(ProductModel item, int quantityUserWantBy) {
    item.quantityUserWantBuy = quantityUserWantBy;
    _cartItems.add(item);
    notifyListeners();
  }

  bool isProductInCart(int productId) {
    return _cartItems.any((item) => item.productID == productId);
  }

  void removeFromCart(ProductModel item) {
    _cartItems.remove(item);
    notifyListeners();
  }

  void clearCart() {
    _cartItems.clear();
    notifyListeners();
  }
}
