import 'package:electronic_equipment_store/core/constants/my_textformfield.dart';
import 'package:electronic_equipment_store/representation/screens/widgets/button_widget.dart';
import 'package:flutter/material.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';
import '../../../core/constants/color_constants.dart';
import '../../../core/constants/dismension_constants.dart';
import '../../../core/constants/textstyle_constants.dart';
import '../../../utils/dialog_helper.dart';

class RegisterAccount extends StatefulWidget {
  final Function()? onTap;
  const RegisterAccount({super.key, required this.onTap});

  @override
  State<RegisterAccount> createState() => _RegisterAccountState();
}

class _RegisterAccountState extends State<RegisterAccount> {
  TextEditingController emailController = TextEditingController();
  TextEditingController passwordController = TextEditingController();
  TextEditingController confirmPasswordController = TextEditingController();

  bool _showPass = false;
  bool _showConfirmPass = false;
  int? accountID;
  Future<void> createAccount() async {
    if (emailController.text.isEmpty) {
      showCustomDialog(context, 'Lỗi', 'Vui lòng nhập "Email".', true);
    } else if (validateEmail(emailController.text) != null) {
      showCustomDialog(context, 'Lỗi', 'Email không hợp lệ', true);
    } else if (passwordController.text.isEmpty) {
      showCustomDialog(context, 'Lỗi', 'Bạn chưa điền "Mật khẩu".', true);
    } else if (validatePassword(passwordController.text) != null) {
      showCustomDialog(context, 'Lỗi', 'Mật khẩu không hợp lệ', true);
    } else if (confirmPasswordController.text.isEmpty) {
      showCustomDialog(
          context, 'Lỗi', 'Bạn chưa điền "Xác nhận mật khẩu".', true);
    } else if (passwordController.text != confirmPasswordController.text) {
      showCustomDialog(
          context, 'Lỗi', 'Xác nhận mật khẩu không trùng khớp.', true);
    } else {
      showDialog(
        context: context,
        builder: (context) {
          return const Center(
            child: CircularProgressIndicator(
              color: ColorPalette.primaryColor,
            ),
          );
        },
      );
      // TODO Login Function
    }
  }

  void onToggleShowPass() {
    setState(() {
      _showPass = !_showPass;
    });
  }

  void onToggleShowConfirmPass() {
    setState(() {
      _showConfirmPass = !_showConfirmPass;
    });
  }

  String? validateEmail(String? email) {
    if (email == null || email.isEmpty) {
      return 'Vui lòng nhập Email';
    }

    String emailPattern = r'^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$';
    RegExp regex = RegExp(emailPattern);

    if (!regex.hasMatch(email)) {
      return 'Email không hợp lệ';
    }

    return null;
  }

  String? validatePassword(String? password) {
    if (password == null || password.isEmpty) {
      return 'Vui lòng nhập Password';
    }

    if (password.contains(',')) {
      return 'Không được chứa dấu ","';
    }

    if (password.contains(' ')) {
      return 'Mật khẩu không được chứa khoảng trắng';
    }

    return null;
  }

  Widget createAccountWidget() {
    return Column(
      children: [
        const SizedBox(height: 20),
        const Icon(
          FontAwesomeIcons.userPlus,
          size: 50,
        ),
        const SizedBox(height: 20),
        Padding(
          padding: const EdgeInsets.symmetric(horizontal: 20),
          child: Column(
            children: [
              Container(
                alignment: Alignment.centerLeft,
                child: Text("Đăng ký", style: TextStyles.h4.bold),
              ),
              const SizedBox(height: 5),

              // Let's create an account for you!
              Container(
                alignment: Alignment.centerLeft,
                child: Text(
                  "Hãy tạo một tài khoản cho bạn!",
                  style: TextStyles.h5.setColor(ColorPalette.textHide),
                ),
              ),
              const SizedBox(height: 25),

              // Email
              MyTextFormField(
                controller: emailController,
                hintText: 'Email',
                obscureText: false,
                validator: validateEmail,
                autovalidateMode: AutovalidateMode.onUserInteraction,
                prefixIcon: const Icon(
                  FontAwesomeIcons.solidEnvelope,
                  size: kDefaultIconSize18,
                ),
              ),
              const SizedBox(height: 10),

              //  Password
              MyTextFormField(
                controller: passwordController,
                hintText: 'Mật khẩu',
                obscureText: !_showPass,
                validator: validatePassword,
                autovalidateMode: AutovalidateMode.onUserInteraction,
                prefixIcon: const Icon(
                  FontAwesomeIcons.key,
                  size: kDefaultIconSize18,
                ),
                suffixIcon: GestureDetector(
                  onTap: onToggleShowPass,
                  child: Icon(
                    _showPass
                        ? FontAwesomeIcons.eyeSlash
                        : FontAwesomeIcons.eye,
                    size: kDefaultIconSize18,
                    color: ColorPalette.primaryColor,
                  ),
                ),
              ),
              const SizedBox(height: 10),

              // Confirm password
              MyTextFormField(
                controller: confirmPasswordController,
                hintText: 'Xác nhận mật khẩu',
                obscureText: !_showConfirmPass,
                validator: (value) {
                  if (value == null || value.isEmpty) {
                    return 'Vui lòng nhập Confirm Password';
                  }
                  if (value.contains(' ')) {
                    return 'Mật khẩu không được chứa khoảng trắng';
                  }
                  if (value.contains(',')) {
                    return 'Không được chứa dấu ","';
                  }
                  if (value != passwordController.text) {
                    return 'Xác nhận mật khẩu không trùng khớp với mật khẩu';
                  }
                  return null;
                },
                autovalidateMode: AutovalidateMode.onUserInteraction,
                suffixIcon: GestureDetector(
                  onTap: onToggleShowConfirmPass,
                  child: Icon(
                    _showConfirmPass
                        ? FontAwesomeIcons.eyeSlash
                        : FontAwesomeIcons.eye,
                    size: kDefaultIconSize18,
                    color: ColorPalette.primaryColor,
                  ),
                ),
                prefixIcon: const Icon(
                  FontAwesomeIcons.check,
                  size: kDefaultIconSize18,
                ),
              ),
              const SizedBox(height: 25),
              
              ButtonWidget(
                title: 'Tiếp tục',
                size: 22,
                height: 70,
                onTap: createAccount,
              ),
            ],
          ),
        ),
        const SizedBox(height: 20),
      ],
    );
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: SingleChildScrollView(
        child: Column(
          children: [
            createAccountWidget(),
            Row(
              mainAxisAlignment: MainAxisAlignment.center,
              children: [
                Text(
                  "Bạn đã có tài khoản?",
                  style: TextStyles.h5,
                ),
                const SizedBox(width: 10),
                GestureDetector(
                  onTap: widget.onTap,
                  child: Text(
                    'Đăng nhập ngay.',
                    style: TextStyles.h5.bold.setColor(Colors.blue),
                  ),
                )
              ],
            ),
          ],
        ),
      ),
    );
  }
}
