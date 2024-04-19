import 'package:auto_size_text/auto_size_text.dart';
import 'package:carousel_slider/carousel_controller.dart';
import 'package:electronic_equipment_store/models/feedback_model.dart';
import 'package:electronic_equipment_store/models/product_detail_model.dart';
import 'package:electronic_equipment_store/models/product_image_model.dart';
import 'package:electronic_equipment_store/models/product_model.dart';
import 'package:electronic_equipment_store/representation/screens/product_detail/widgets/image_slider.dart';
import 'package:electronic_equipment_store/representation/screens/widgets/app_bar_main.dart';
import 'package:electronic_equipment_store/representation/screens/widgets/button_widget.dart';
import 'package:electronic_equipment_store/representation/widgets/indicator_widget.dart';
import 'package:electronic_equipment_store/utils/asset_helper.dart';
import 'package:expandable_text/expandable_text.dart';
import 'package:flutter/material.dart';
import 'package:flutter_rating_bar/flutter_rating_bar.dart';
import 'package:font_awesome_flutter/font_awesome_flutter.dart';
import 'package:intl/intl.dart';
import '../../../core/constants/color_constants.dart';
import '../../../core/constants/dismension_constants.dart';
import '../../../core/constants/textstyle_constants.dart';

class ProductDetail extends StatefulWidget {
  final ProductModel productModel;
  final List<ProductDetailModel> productDetails;
  final List<ProductImageModel> productImageModel;
  final List<FeedbackModel> feedbackList;
  const ProductDetail({
    super.key,
    required this.productModel,
    required this.productDetails,
    required this.productImageModel,
    required this.feedbackList,
  });
  static const String routeName = '/product_detail';
  @override
  State<ProductDetail> createState() => _ProductDetailState();
}

class _ProductDetailState extends State<ProductDetail> {
  final CarouselController _controller = CarouselController();
  final TextEditingController _quantityController =
      TextEditingController(text: '1');

  int _currentImage = 0;
  int quantity = 1;

  @override
  void initState() {
    super.initState();
  }

  Widget buildRatingHeader() {
    return Padding(
      padding: const EdgeInsets.all(10),
      child: Row(
        mainAxisAlignment: MainAxisAlignment.spaceBetween,
        children: [
          Row(
            children: [
              const Icon(
                FontAwesomeIcons.solidStar,
                color: Colors.amber,
              ),
              const SizedBox(width: 10),
              Text(
                'Khách hàng đánh giá',
                style: TextStyles.h5.bold,
              ),
            ],
          ),
          Text(
            '${widget.feedbackList.length} đánh giá',
            style: TextStyles.defaultStyle.setColor(Colors.blue),
          ),
        ],
      ),
    );
  }

  Widget buildFeedbackList() {
    if (widget.feedbackList.isEmpty) {
      return const Column(
        children: [
          Row(
            children: [
              SizedBox(width: 10),
              Text('Chưa có đánh giá nào'),
            ],
          ),
          SizedBox(height: 10),
        ],
      );
    } else {
      return ListView.builder(
        shrinkWrap: true,
        itemCount: widget.feedbackList.length,
        itemBuilder: (context, index) {
          return buildFeedbackItem(widget.feedbackList[index]);
        },
      );
    }
  }

  Widget buildFeedbackItem(FeedbackModel feedback) {
    return Padding(
      padding: const EdgeInsets.all(10.0),
      child: Container(
        padding: const EdgeInsets.all(12),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.circular(kDefaultCircle14),
          border: Border.all(color: ColorPalette.textHide),
        ),
        child: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Row(
              mainAxisAlignment: MainAxisAlignment.spaceBetween,
              children: [
                Row(
                  children: [
                    CircleAvatar(
                      radius: 10,
                      backgroundImage: NetworkImage(
                          feedback.userModel.avatarUrl ??
                              AssetHelper.imageAvatarDefault),
                    ),
                    const SizedBox(width: 10),
                    Text(
                      feedback.userModel.name,
                      style: TextStyles.defaultStyle.bold,
                    ),
                  ],
                ),
                Text(
                  DateFormat.yMd().format(feedback.createdDate),
                ),
              ],
            ),
            const SizedBox(height: 10),
            Row(
              children: [
                RatingBar(
                  itemSize: 18,
                  initialRating: feedback.ratingPoint.toDouble(),
                  minRating: 1,
                  direction: Axis.horizontal,
                  allowHalfRating: false,
                  itemCount: 5,
                  itemPadding: const EdgeInsets.symmetric(horizontal: 2.0),
                  ratingWidget: RatingWidget(
                    full: const Icon(
                      FontAwesomeIcons.solidStar,
                      color: Colors.amber,
                    ),
                    half: const Icon(FontAwesomeIcons.solidStar),
                    empty: const Icon(
                      FontAwesomeIcons.star,
                      color: Colors.amber,
                    ),
                  ),
                  onRatingUpdate: (value) {},
                  ignoreGestures: true,
                ),
              ],
            ),
            const SizedBox(height: 10),
            AutoSizeText(
              feedback.description,
              minFontSize: 14,
              maxLines: 2,
              overflow: TextOverflow.ellipsis,
              style: TextStyles.defaultStyle
                  .setColor(ColorPalette.textColor.withOpacity(0.6)),
            ),
            const SizedBox(height: 10),
          ],
        ),
      ),
    );
  }

  double calculateAverageRating(List<FeedbackModel> feedbacks) {
    if (feedbacks.isEmpty) {
      return 0.0;
    }

    double totalRating = 0.0;
    for (var feedback in feedbacks) {
      totalRating += feedback.ratingPoint;
    }

    return totalRating / feedbacks.length;
  }

  @override
  Widget build(BuildContext context) {
    // final cartProvider = Provider.of<CartProvider>(context, listen: false);
    //TODO double check need provider or not

    final ProductModel productModel = widget.productModel;
    final List<ProductDetailModel> productDetails = widget.productDetails;
    final List<ProductImageModel> productImages = widget.productImageModel;
    Size size = MediaQuery.of(context).size;

    return AppBarMain(
      titleAppbar: 'Chi tiết sản phẩm',
      leading: GestureDetector(
        onTap: () {
          Navigator.pop(context);
        },
        child: Container(
          color: ColorPalette.backgroundScaffoldColor,
          child: const Icon(
            FontAwesomeIcons.angleLeft,
          ),
        ),
      ),
      child: Scaffold(
        body: Column(
          crossAxisAlignment: CrossAxisAlignment.start,
          children: [
            Expanded(
              child: Padding(
                padding: const EdgeInsets.symmetric(horizontal: 10),
                child: ListView(
                  children: [
                    // load ảnh productDetail
                    Stack(
                      children: [
                        ImageSlider(
                          productImages: productImages,
                          currentImage: _currentImage,
                          onPageChanged: (int index) {
                            setState(() {
                              _currentImage = index;
                            });
                          },
                          carouselController: _controller,
                        ),
                      ],
                    ),
                    const SizedBox(height: 10),
                    // cục indicator
                    Center(
                      child: SizedBox(
                        height: 8,
                        child: ListView.builder(
                          // nằm giữa hay không là nó nằm ở shrinWrap này nè. Cho phép ListView co lại theo nội dung
                          shrinkWrap: true,
                          itemCount: productImages.length,
                          scrollDirection: Axis.horizontal,
                          itemBuilder: (context, index) {
                            return buildIndicator(index == _currentImage, size);
                          },
                        ),
                      ),
                    ),
                    const SizedBox(height: 10),
                    // information product
                    Container(
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(kDefaultCircle14),
                          color: ColorPalette.hideColor),
                      child: Padding(
                        padding: const EdgeInsets.all(10),
                        child: Column(
                          crossAxisAlignment: CrossAxisAlignment.start,
                          children: [
                            // name product
                            AutoSizeText(
                              maxLines: 1,
                              productModel.productName,
                              style: TextStyles.h4.bold,
                              minFontSize: 25,
                              overflow: TextOverflow.ellipsis,
                            ),
                            const SizedBox(height: 10),
                            // description
                            ExpandableText(
                              productModel.productDecription ?? 'N/A',
                              expandText: 'Xem thêm',
                              linkColor: Colors.blue,
                              collapseText: 'Thu gọn',
                              maxLines: 2,
                              style: TextStyles.defaultStyle.setColor(
                                ColorPalette.grey3,
                              ),
                            ),
                            const SizedBox(height: 10),

                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Text(
                                      'Thương hiệu',
                                      style: TextStyles.h5.bold,
                                    ),
                                    const SizedBox(height: 5),
                                    const Text(
                                      'Chưa có',
                                    )
                                  ],
                                ),
                                if(productModel.categoryID != null)
                                Column(
                                  crossAxisAlignment: CrossAxisAlignment.end,
                                  children: [
                                    Text(
                                      'Phân loại',
                                      style: TextStyles.h5.bold,
                                    ),
                                    const SizedBox(height: 5),
                                      Row(
                                        mainAxisAlignment:
                                            MainAxisAlignment.start,
                                        children: [
                                          Text( 'từ từ rồi làm'
                                            ,
                                            style: TextStyles.h5,
                                          ),
                                          const SizedBox(height: 5),
                                        ],
                                      )
                                  ],
                                ),
                              ],
                            ),
                            const SizedBox(height: 10),
                            Row(
                              mainAxisAlignment: MainAxisAlignment.spaceBetween,
                              children: [
                                Column(
                                  crossAxisAlignment: CrossAxisAlignment.start,
                                  children: [
                                    Text(
                                      'Thuộc tính',
                                      style: TextStyles.h5.bold,
                                    ),
                                    const SizedBox(height: 5),
                                    for (var productDetail in productDetails)
                                      Row(
                                        mainAxisAlignment:
                                            MainAxisAlignment.start,
                                        children: [
                                          Text(
                                            '${productDetail.name}: ',
                                            style: TextStyles.h5.bold,
                                          ),
                                          const SizedBox(height: 5),
                                          Text(
                                            productDetail.value,
                                            style: TextStyles.h5,
                                          ),
                                        ],
                                      )
                                  ],
                                ),
                              ],
                            ),
                            const SizedBox(height: 10),
                          ],
                        ),
                      ),
                    ),
                    const SizedBox(height: 20),
                    // những bài đánh giá
                    Container(
                      decoration: BoxDecoration(
                          borderRadius: BorderRadius.circular(kDefaultCircle14),
                          color: ColorPalette.hideColor),
                      child: Column(
                        crossAxisAlignment: CrossAxisAlignment.start,
                        children: [
                          buildRatingHeader(),
                          const Divider(
                            thickness: 0.5,
                            color: ColorPalette.primaryColor,
                          ),
                          // List đánh giá
                          buildFeedbackList(),
                        ],
                      ),
                    ),
                  ],
                ),
              ),
            ),
            const SizedBox(height: 10),
            // cục ở dưới màn hình Mua
            Container(
              decoration: const BoxDecoration(
                color: ColorPalette.backgroundScaffoldColor,
                borderRadius: BorderRadius.only(
                  topLeft: Radius.circular(kDefaultCircle14),
                  topRight: Radius.circular(kDefaultCircle14),
                ),
              ),
              padding: const EdgeInsets.all(20),
              child: Column(
                children: [
                  Container(
                    decoration: BoxDecoration(
                      color: ColorPalette.hideColor,
                      borderRadius: BorderRadius.circular(kDefaultCircle14),
                      border: Border.all(color: ColorPalette.textHide),
                    ),
                    child: Column(
                      children: [
                        Padding(
                          padding: const EdgeInsets.fromLTRB(10, 20, 10, 10),
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Row(
                                children: [
                                  Text(
                                    'Giá Thành',
                                    style: TextStyles.defaultStyle.bold,
                                  ),
                                ],
                              ),
                              Padding(
                                padding: const EdgeInsets.only(right: 12),
                                child: Text(
                                  ' ${NumberFormat.currency(locale: 'vi_VN', symbol: 'vnđ').format(productModel.price)}',
                                ),
                              ),
                            ],
                          ),
                        ),
                        Padding(
                          padding: const EdgeInsets.fromLTRB(10, 0, 10, 10),
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              const Row(
                                children: [
                                  Text(
                                    'Số lượng',
                                    style:
                                        TextStyle(fontWeight: FontWeight.bold),
                                  ),
                                ],
                              ),
                              Row(
                                children: [
                                  IconButton(
                                    icon: const Icon(Icons.remove),
                                    onPressed: () {
                                      setState(() {
                                        if (quantity > 1) {
                                          quantity--;
                                          _quantityController.text =
                                              quantity.toString();
                                        }
                                      });
                                    },
                                  ),
                                  SizedBox(
                                    width: 50,
                                    child: TextFormField(
                                      controller: _quantityController,
                                      textAlign: TextAlign.center,
                                      keyboardType: TextInputType.number,
                                      decoration: const InputDecoration(
                                        border: InputBorder.none,
                                      ),
                                      onChanged: (value) {
                                        setState(() {
                                          quantity = int.tryParse(value) ?? 1;
                                          _quantityController.text =
                                              quantity.toString();
                                        });
                                      },
                                    ),
                                  ),
                                  IconButton(
                                    icon: const Icon(Icons.add),
                                    onPressed: () {
                                      setState(() {
                                        quantity++;
                                        _quantityController.text =
                                            quantity.toString();
                                      });
                                    },
                                  ),
                                ],
                              ),
                            ],
                          ),
                        ),
                        Padding(
                          padding: const EdgeInsets.fromLTRB(10, 0, 10, 10),
                          child: Row(
                            mainAxisAlignment: MainAxisAlignment.spaceBetween,
                            children: [
                              Row(
                                children: [
                                  Text(
                                    'Thành Tiền',
                                    style: TextStyles.defaultStyle.bold,
                                  ),
                                ],
                              ),
                              Padding(
                                padding: const EdgeInsets.only(right: 12),
                                child: Text(
                                  ' ${NumberFormat.currency(locale: 'vi_VN', symbol: 'vnđ').format(productModel.price*quantity)}',
                                ),
                              ),
                            ],
                          ),
                        ),
                        Padding(
                          padding: const EdgeInsets.symmetric(horizontal: 12),
                          child: Column(
                            crossAxisAlignment: CrossAxisAlignment.start,
                            children: [
                              const SizedBox(height: 20),
                              Row(
                                mainAxisAlignment:
                                    MainAxisAlignment.spaceBetween,
                                children: [
                                  ButtonWidget(
                                    title: 'Thêm vào giỏ hàng',
                                    onTap: () {
                                      //TODO Function add to cart
                                    },
                                    height: 70,
                                    size: 18,
                                  ),
                                  ButtonWidget(
                                    title: 'Mua Ngay',
                                    onTap: () {
                                      //TODO Function Buy Now
                                    },
                                    color: Colors.orange,
                                    height: 70,
                                    width: 180,
                                    size: 18,
                                  )
                                ],
                              ),
                              // add to cart button

                              const SizedBox(height: 10),
                            ],
                          ),
                        ),
                      ],
                    ),
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
