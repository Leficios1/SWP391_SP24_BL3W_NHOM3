import 'package:flutter/material.dart';

class CustomerMainScreen extends StatefulWidget {
  const CustomerMainScreen({super.key});

  static const String routeName = '/customer_main_screen';

  @override
  State<CustomerMainScreen> createState() => _CustomerMainScreenState();
}

class _CustomerMainScreenState extends State<CustomerMainScreen> {
  @override
  Widget build(BuildContext context) {
    return Scaffold(body: Text("This is Customer Main Screen"));
  }
}