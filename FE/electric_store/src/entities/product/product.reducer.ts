import { createAsyncThunk, createSlice, isFulfilled, isPending } from "@reduxjs/toolkit";
import { IAllProductProps, IProductProps } from "../../shared/models/product";
import { EntityState, IQueryParams } from "../../shared/utils/reducer.utils";
import { PRODUCT } from "./product.api";
import axios from "axios";


export const initialState: EntityState<any> = {
    dataDetail: null,
    data: null,
    message: "",
    loading: false,
}


export type ProductState = Readonly<typeof initialState>

export const getAllproduct = createAsyncThunk("product/getAll", async ({ size, page }: IQueryParams) => {
    const requestUrl = `${PRODUCT.CUSTOMER.GETPRODUCTALL}?size=${size}&page=${page}`;
    return await axios.get<IAllProductProps>(requestUrl);
})


export const getProductDetail = createAsyncThunk("product/getDetail", async (id: string | number) => {
    const requestURL = `${PRODUCT.CUSTOMER.GETPRODUCTDETAIL}/${id}`
    return await axios.get<IProductProps>(requestURL)
})


export const ProductSlice = createSlice({
    name: "product",
    initialState: initialState as ProductState,
    reducers: {
        reset() {
            return {
                ...initialState
            }
        }

    },
    extraReducers(builder) {
        builder
            .addMatcher(isPending(getAllproduct, getProductDetail), (state) => {
                state.loading = true

            })
            .addMatcher(isFulfilled(getAllproduct), (state, action) => {
                const { data } = action.payload
                return {
                    ...state,
                    data: data,
                    loading: false
                }
            })
            .addMatcher(isFulfilled(getProductDetail), (state, action) => {
                const { data } = action.payload
                return {
                    ...state,
                    dataDetail: data,
                    loading: false
                }
            })
    }
})


export const { reset } = ProductSlice.actions

export default ProductSlice.reducer