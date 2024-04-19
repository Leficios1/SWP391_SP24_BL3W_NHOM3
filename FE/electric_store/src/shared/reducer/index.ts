import { ReducersMapObject } from "@reduxjs/toolkit";
import authentication from "./authentication.reducer";
import product from "../../entities/product/product.reducer";
import cart from "../../entities/cart/cart.reducer";
import order from "../../entities/order/order.reducer";

const rootReducer: ReducersMapObject = {
    authentication,
    product,
    cart,
    order
}


export default rootReducer