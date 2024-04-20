import 'package:flutter/cupertino.dart';


import '../models/user_model.dart';

class AuthProvider with ChangeNotifier {
  bool isLoggedIn = false;
  static UserModel? userModel;

  void setUser(UserModel user) {
    userModel = user;
    isLoggedIn = true;
    notifyListeners();
  }

  void clearUser() {
    userModel = null;
    isLoggedIn = false;
    notifyListeners();
  }
}
