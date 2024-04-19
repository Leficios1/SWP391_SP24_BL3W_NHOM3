import 'package:electronic_equipment_store/models/category_model.dart';

class ProductModel {
  int productID;
  String productName;
  String? productDecription;
  String? productImage;
  int quantity;
  double price;
  DateTime? warrantyPeriod;
  List<CategoryModel>? categories;

  ProductModel({
    required this.productID,
    required this.productName,
    this.productDecription,
    this.productImage,
    required this.quantity,
    required this.price,
    this.warrantyPeriod,
    this.categories,
  });

  factory ProductModel.fromJson(Map<String, dynamic> json) {

    return ProductModel(
      productID: json['id'],
      productName: json['name'],
      productDecription: json['description'],
      productImage: json['imageUrl'],
      quantity: json['quantity'],
      price: json['price'],
    );
  }
}
