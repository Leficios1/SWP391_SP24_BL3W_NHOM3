import 'package:electronic_equipment_store/core/constants/color_constants.dart';
import 'package:electronic_equipment_store/core/constants/dismension_constants.dart';
import 'package:electronic_equipment_store/representation/screens/widgets/app_bar_main.dart';
import 'package:flutter/material.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';

class HomeScreen extends StatefulWidget {
  const HomeScreen({super.key});

  @override
  State<HomeScreen> createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen>
    with SingleTickerProviderStateMixin {
  late AnimationController _controller;

  @override
  void initState() {
    super.initState();
    _controller = AnimationController(vsync: this);
  }

  @override
  void dispose() {
    _controller.dispose();
    super.dispose();
  }

  final GlobalKey<ScaffoldState> _scaffoldKey =
      GlobalKey<ScaffoldState>(); // để gọi Drawer thêm nut logout

  @override
  Widget build(BuildContext context) {
    return AppBarMain(leading: Builder(builder: (context) {
        return GestureDetector(
          onTap: () {
             _scaffoldKey.currentState?.openDrawer();
          },
          child: const Icon(
            FontAwesomeIcons.bars,
            size: kDefaultIconSize18,
            color: ColorPalette.primaryColor,
          ),
        );
      }),
      child: const Scaffold(
        body: Text("this is Home Screen"),
      ),);
  }
}