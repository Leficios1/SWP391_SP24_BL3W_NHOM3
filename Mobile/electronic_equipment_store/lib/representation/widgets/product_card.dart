import 'package:auto_size_text/auto_size_text.dart';
import 'package:flutter/material.dart';
import 'package:intl/intl.dart';
import '../../core/constants/color_constants.dart';
import '../../core/constants/dismension_constants.dart';
import '../../core/constants/textstyle_constants.dart';
import '../../models/product_model.dart';

class ProductCard extends StatefulWidget {
  final ProductModel product;

  const ProductCard({
    super.key,
    required this.product,
  });

  @override
  State<ProductCard> createState() => _ProductCardState();
}

class _ProductCardState extends State<ProductCard> {
  bool isFavorite = false;
  final AutoSizeGroup autoSizeGroup = AutoSizeGroup();

  @override
  void initState() {
    super.initState();
  }

  @override
  void dispose() {
    super.dispose();
  }

  @override
  Widget build(BuildContext context) {
    return ClipRRect(
      borderRadius: BorderRadius.circular(kDefaultCircle14),
      child: Container(
        color: ColorPalette.hideColor,
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            //img
                AspectRatio(
                  aspectRatio: 13 / 9,
                  child: Image.network(widget.product.productImage!,
                      fit: BoxFit.cover),
                ),
            const SizedBox(height: 8),
            Padding(
              padding: const EdgeInsets.symmetric(horizontal: 10),
              child: Column(
                crossAxisAlignment: CrossAxisAlignment.start,
                children: [
                  SizedBox(
                    width: 160,
                    child: AutoSizeText(
                      overflow: TextOverflow.ellipsis,
                      minFontSize: 16,
                      maxLines: 2,
                      widget.product.productName,
                      style: TextStyles.h5.bold,
                    ),
                  ),
                  const SizedBox(height: 18),
                  Row(
                    children: [
                      Expanded(
                        child: SizedBox(
                          width: 160,
                          child: AutoSizeText.rich(
                            group: autoSizeGroup,
                            minFontSize: 14,
                            overflow: TextOverflow.ellipsis,
                            maxLines: 1,
                            TextSpan(
                              children: [
                                TextSpan(
                                    text: 'Thương hiệu: ',
                                    style: TextStyles.defaultStyle.bold),
                                const TextSpan(
                                  text:'N/A',
                                  //TODO thương hiệu
                                )
                              ],
                            ),
                          ),
                        ),
                      ),
                    ],
                  ),
                  const SizedBox(height: 4),
                  //Price
                    SizedBox(
                      width: 160,
                      child: AutoSizeText.rich(
                        group: autoSizeGroup,
                        maxLines: 2,
                        TextSpan(
                          children: [
                            TextSpan(
                                text: 'Giá: ',
                                style: TextStyles.defaultStyle.bold),
                            TextSpan(
                              text:
                                  NumberFormat.currency(locale: 'vi_VN', symbol: 'vnđ').format(widget.product.price),
                                  style: const TextStyle(color: Colors.red, fontWeight: FontWeight.bold),
                            ),
                          ],
                        ),
                      ),
                    ),
                  const SizedBox(height: 4),
                  if(widget.product.quantity > 0)
                    Text(
                      "CÓ SẴN",
                      style: TextStyles.h5.bold.setColor(Colors.green),
                    ),
                  if(widget.product.quantity == 0)
                  Text(
                      "HÊT HÀNG",
                      style: TextStyles.h5.bold.setColor(Colors.orange),
                    ),
                ],
              ),
            ),
          ],
        ),
      ),
    );
  }
}
