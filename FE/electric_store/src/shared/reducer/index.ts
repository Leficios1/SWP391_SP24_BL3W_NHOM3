import { ReducersMapObject } from "@reduxjs/toolkit";
import authentication from "./authentication.reducer";
import product from "../../entities/product/product.reducer";
import cart from "../../entities/cart/cart.reducer";

const rootReducer: ReducersMapObject = {
    authentication,
    product,
    cart
}


export default rootReducer