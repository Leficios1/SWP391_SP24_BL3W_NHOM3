import { createAsyncThunk, createSlice, isFulfilled, isPending } from "@reduxjs/toolkit";
import { EntityState } from "../../shared/utils/reducer.utils";
import { IAddingCartProps } from "../../shared/models/cart";
import { CART } from "./cart.api";
import axios from "axios";

export const initialState: EntityState<any> = {
    data: null,
    dataDetail: null,
    loading: false,
    message: ""
}


export type CartState = Readonly<typeof initialState>


export const getCartByUserId = createAsyncThunk("cart/getcartbyuserid", async (id: string | number) => {
    const requestUrl = `${CART.CUSTOMER.GETCARTPRODUCT}/${id}`;
    return await axios.get<any>(requestUrl)
})

export const createProductToCart = createAsyncThunk("cart/addingproducttocart", async (product: IAddingCartProps, thunkApi) => {
    const requestUrl = await axios.post<any>(`${CART.CUSTOMER.ADDINGPRODUCT}`, product);
    thunkApi.dispatch(getCartByUserId(product.userId))
    return requestUrl
})



export const CartSlice = createSlice({
    name: "cart",
    initialState: initialState as CartState,
    reducers: {},
    extraReducers(builder) {
        builder.
            addMatcher(isPending(createProductToCart, getCartByUserId), (state, action) => {
                return {
                    ...state,
                    loading: true,
                }
            })

            .addMatcher(isFulfilled(getCartByUserId), (state, action) => {
                const { data } = action.payload
                return {
                    ...state,
                    loading: false,
                    dataDetail: data
                }
            })
            .addMatcher(isFulfilled(createProductToCart), (state, action) => {
                const { data } = action.payload
                return {
                    ...state,
                    loading: false,
                    data: data
                }
            })


    },
})


export default CartSlice.reducer

