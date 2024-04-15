import 'role_model.dart';

class UserModel {
  int userID;
  String name;
  String email;
  String? phone;
  String? address;
  DateTime? dateOfBirth;
  RoleModel role;
  String? avatarUrl;
  String? gender;
  bool status;


  UserModel({
    required this.userID,
    required this.name,
    required this.email,
    this.phone,
    this.address,
    this.dateOfBirth,
    required this.role,
    this.avatarUrl,
    this.gender,
    required this.status,
  });

  factory UserModel.fromJson(Map<dynamic, dynamic> json) {
    return UserModel(
      userID: json['id'],
      name: json['name'],
      email: json['email'],
      phone: json['phone'],
      address: json['address'],
      dateOfBirth: json['dateOfBirth'],
      role: RoleModel.fromJson(json['role']),
      avatarUrl: json['avatarUrl'],
      gender: json['gender'],
      status: json['status'],
    );
  }
}
