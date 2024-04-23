
class UserModel {
  int userID;
  String name;
  String email;
  String? password;
  String? phone;
  String? address;
  DateTime? dateOfBirth;
  int roleId;
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
    required this.roleId,
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
      dateOfBirth: DateTime.parse(json['dateOfBirth']) ,
      roleId: json['roleId'],
      avatarUrl: json['avatarUrl'],
      gender: json['gender'],
      status: json['status'],
    );
  }

  Map<dynamic, dynamic> toJson() {
    return {
      'id': userID,
      'email': email,
      'password': password,
      'name': name,
      'phone' : phone,
      'address' :address,
      'dateOfBirth' : dateOfBirth.toString(),
      'gender' : gender,
      'status': status,
      'role': roleId,
    };
  }
}
