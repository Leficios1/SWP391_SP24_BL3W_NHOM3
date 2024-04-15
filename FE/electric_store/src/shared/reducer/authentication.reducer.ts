import { createAsyncThunk, createSlice, SerializedError } from "@reduxjs/toolkit"
import axios, { AxiosResponse } from "axios"
import { ILoginProps } from "../models/auth"
import { AppThunk, useAppDispatch } from "../../config/store"

export const initialState = {
    loading: false,
    isAuthenticated: false,
    loginSuccess: false,
    loginError: false,
    errorMessage: null as unknown as string
}

export type AuthenticationState = Readonly<typeof initialState>

export const getAccount = createAsyncThunk("authentication/get_account", async () => axios.get("api/Auth/login/get-user-by-token/fdsf"))

export const authenticate = createAsyncThunk("authentication/login", async (auth: ILoginProps) => axios.post("https://localhost:7152/api/Auth/login", auth))

export const login: (username: string, password: string) => AppThunk = (email: string, password: string) => async dispatch => {
    const result = await dispatch(authenticate({ email, password }));
    const response = result.payload as AxiosResponse

    console.log(response?.data);

}


export const AuthenticationSlice = createSlice({
    name: "authentication",
    initialState: initialState as AuthenticationState,
    reducers: {},
    extraReducers(builder) {
        builder
            .addCase(authenticate.pending, (state, action) => ({
                ...initialState,
                loading: true
            }))
            .addCase(authenticate.rejected, (state, action) => ({
                ...initialState,
                loginError: true,

            }))
            .addCase(authenticate.fulfilled, (state, action) => (
                {
                    ...initialState,
                    loading: false,
                    loginError: false,
                    loginSuccess: true
                }
            ))
    },
})

export default AuthenticationSlice.reducer