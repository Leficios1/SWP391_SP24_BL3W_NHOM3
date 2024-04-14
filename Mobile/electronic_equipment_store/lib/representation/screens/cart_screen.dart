import 'package:electronic_equipment_store/representation/screens/widgets/app_bar_main.dart';
import 'package:flutter/material.dart';
import '../../../utils/asset_helper.dart';
import '../../../utils/image_helper.dart';

class CartScreen extends StatefulWidget {
  const CartScreen({super.key});
  static const String routeName = '/main_cart_screen';
  @override
  State<CartScreen> createState() => _CartScreenState();
}

class _CartScreenState extends State<CartScreen>
    with SingleTickerProviderStateMixin {


  @override
  void initState() {
    super.initState();
  }

  @override
  Widget build(BuildContext context) {
    return AppBarMain(
      leading: FractionallySizedBox(
        widthFactor: 0.8,
        heightFactor: 0.8,
        child: ImageHelper.loadFromAsset(
          AssetHelper.imageLogo,
        ),
      ),
      child: const Scaffold(
        body: Padding(
          padding: EdgeInsets.symmetric(horizontal: 10),
          child: Text("this is cart Screen")
        ),
      ),
    );
  }
}
