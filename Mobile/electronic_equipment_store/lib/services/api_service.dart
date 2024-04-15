import 'package:electronic_equipment_store/models/category_model.dart';
import 'package:electronic_equipment_store/models/feedback_model.dart';
import 'package:electronic_equipment_store/models/product_detail_model.dart';
import 'package:electronic_equipment_store/models/product_image_model.dart';
import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:electronic_equipment_store/models/role_model.dart';
import 'package:electronic_equipment_store/models/user_model.dart';

class ApiService {

  static Future<List<CategoryModel>?> getAllCategory() async {
    List<CategoryModel> categorys = [
      CategoryModel(categoryID: 1, categoryName: "đồ điện"),
      CategoryModel(categoryID: 2, categoryName: "đồ điện 1"),
      CategoryModel(categoryID: 3, categoryName: "đồ điện 2"),
    ];
    return categorys;
  }


  static Future<List<ProductModel>?> getAllProduct() async {
    try {

      List<ProductModel> products = 
      [
        ProductModel(productID: 001, productName: "Bếp từ 01", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 1000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
        ProductModel(productID: 001, productName: "Bếp từ 02", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 10000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
        ProductModel(productID: 001, productName: "Bếp từ 03", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 100000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
        ProductModel(productID: 001, productName: "Bếp từ 04", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 1000000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
      ];
      return products;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  static Future<List<ProductModel>?> getAllProductByCategoryName(String name) async {
    try {

      List<ProductModel> products = 
      [
        ProductModel(productID: 001, productName: "Bếp từ 03", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 100000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
        ProductModel(productID: 001, productName: "Bếp từ 04", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 1000000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
      ];
      return products;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  static Future<List<ProductModel>?> getAllProductOnAvailable() async {
    try {

      List<ProductModel> products = 
      [
        ProductModel(productID: 001, productName: "Bếp từ 01", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 100000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
        ProductModel(productID: 001, productName: "Bếp từ 02", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 1000000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]),
      ];
      return products;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }
  
  static Future<ProductModel> getProductByID(int productID) async {
    try {
      return ProductModel(productID: 001, productName: "Bếp từ 02", productDecription: "Bếp dùng điện để tạo ra từ",quantity: 8, productImage: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRqGrNL4tOiFcrx8XjkSD83ZkR_KCgtmZA8ggnvk-LhGw&s" , price: 1000000000, warrantyPeriod: DateTime(2024, 4, 14, 12, 30, 0), categories: <CategoryModel> [CategoryModel(categoryID: 001, categoryName: "đồ điẹn")]);
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  static Future<List<ProductDetailModel>> getListProductDetailByProductByID(int productID) async {
    try {
      List<ProductDetailModel> productDetails = [
        ProductDetailModel(productID: 01, name: 'Tên Attribute 1', value: 'Dữ liệu attribute'),
        ProductDetailModel(productID: 02, name: 'Tên Attribute 2', value: 'Dữ liệu attribute'),
        ProductDetailModel(productID: 03, name: 'Tên Attribute 3', value: 'Dữ liệu attribute')
      ];
      return productDetails;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }


  static Future<List<FeedbackModel>> getFeedbackByProductID(int productID) async {
    try {
      List<FeedbackModel> feedbacks = [
        FeedbackModel(feedBackID: 1, ratingPoint: 3, description: 'tạm được', createdDate: DateTime(2024, 4, 14, 12, 30, 0), userModel: UserModel(userID: 001, name: "Trần Văn Phê", email: "email", role: RoleModel(roleID: 001, roleName: "roleName"), status: true)),
        FeedbackModel(feedBackID: 1, ratingPoint: 5, description: 'xịn đêý', createdDate: DateTime(2024, 4, 14, 12, 30, 0), userModel: UserModel(userID: 002, name: "Nguyễn Văn Pha", email: "email", role: RoleModel(roleID: 001, roleName: "roleName"), status: true))
      ];
      return feedbacks;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }

  static Future<List<ProductImageModel>> getAllProductImgByProductID(int productID) async {
    try {
      List<ProductImageModel> feedbacks = [
        ProductImageModel(productId: 001, imageUrl: "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGnBZAahOtLnMJU9dl77kTQbvJNJ2f3vbUOoj-YYjSwg&s"),
        ProductImageModel(productId: 001, imageUrl: "https://images.squarespace-cdn.com/content/v1/53883795e4b016c956b8d243/1603186829771-7L3IUH5V2M3XALW843MY/3-2.jpg"),
        ProductImageModel(productId: 001, imageUrl: "https://images.squarespace-cdn.com/content/v1/53883795e4b016c956b8d243/1588782925443-ZNSO01ZWEZNMR6604YNG/image-asset.jpeg"),
      ];
      return feedbacks;
    } catch (e) {
      throw Exception('Error: $e');
    }
  }
}