import 'package:electronic_equipment_store/core/constants/color_constants.dart';
import 'package:electronic_equipment_store/core/constants/dismension_constants.dart';
import 'package:electronic_equipment_store/core/constants/textstyle_constants.dart';
import 'package:electronic_equipment_store/representation/screens/splash_screen.dart';
import 'package:electronic_equipment_store/routes.dart';
import 'package:electronic_equipment_store/utils/local_storage_helper.dart';
import 'package:flutter/material.dart';
import 'package:flutter/services.dart';
import 'package:hive_flutter/hive_flutter.dart';
import 'package:intl/date_symbol_data_local.dart';

void main() async {
  WidgetsFlutterBinding.ensureInitialized();
  await Hive.initFlutter();
  await LocalStorageHelper.initLocalStorageHelper();
  await LocalStorageHelper.initSearchBox();
  await Hive.openBox('userBox');
  await initializeDateFormatting('vi_VN', null);

  // ẩn status bar
  SystemChrome.setEnabledSystemUIMode(SystemUiMode.immersiveSticky);
  
  runApp(  
        // TODO Thêm Provider để quản lý stage
          const MyApp(),
 
    );
}

class MyApp extends StatelessWidget {
  const MyApp({super.key});
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      routes: routes,
      debugShowCheckedModeBanner: false,
      title: 'FRS app',
      theme: ThemeData(
        textTheme: TextTheme(bodyLarge: TextStyles.defaultStyle),
        iconTheme: const IconThemeData(
            color: ColorPalette.primaryColor, size: kDefaultIconSize18),
        scaffoldBackgroundColor: ColorPalette.backgroundScaffoldColor,
        colorScheme: ColorScheme.fromSeed(
            primary: ColorPalette.primaryColor,
            seedColor: ColorPalette.backgroundScaffoldColor),
        useMaterial3: true,
      ),
      home: const SplashScreen(),
    );
  }
}