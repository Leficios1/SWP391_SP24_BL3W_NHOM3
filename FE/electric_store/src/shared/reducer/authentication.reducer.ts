import { createAsyncThunk, createSlice, SerializedError } from "@reduxjs/toolkit"
import axios, { AxiosResponse } from "axios"
import { ILoginProps } from "../models/auth"
import { AppThunk, useAppDispatch } from "../../config/store"
import Cookies from "universal-cookie"
import { useNavigate } from "react-router-dom"

export const initialState = {
    loading: false,
    isAuthenticated: false,
    loginSuccess: false,
    loginError: false,
    errorMessage: null as unknown as string,
    account: null as unknown,
}

export type AuthenticationState = Readonly<typeof initialState>

export const getAccount = createAsyncThunk("authentication/get_account", async (jwt_token: string) => axios.get(`https://localhost:7152/api/Auth/login/get-user-by-token/${jwt_token}`))

export const authenticate = createAsyncThunk("authentication/login", async (auth: ILoginProps) => axios.post("https://localhost:7152/api/Auth/login", auth))

export const login: (username: string, password: string) => AppThunk = (email: string, password: string) => async dispatch => {
    const cookie = new Cookies()
    const result = await dispatch(authenticate({ email, password }));
    const response = result.payload as AxiosResponse
    const jwt_token = response.data.tokenString
    const expiration = response.data.expiration

    if (jwt_token && expiration) {
        cookie.set("jwt-token", jwt_token, {
            expires: new Date(expiration)
        })

        dispatch(getAccount(jwt_token));
    }

}

export const logout = () => {
    const cookie = new Cookies()

    if (cookie.get("jwt-token") != null) {
        cookie.remove("jwt-token")
        logoutSession()
    }

}


export const AuthenticationSlice = createSlice({
    name: "authentication",
    initialState: initialState as AuthenticationState,
    reducers: {
        logoutSession() {
            return {
                ...initialState
            }
        }
    },
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
                    ...state,
                    loading: false,
                    loginError: false,
                    loginSuccess: true
                }
            ))

            .addCase(getAccount.pending, (state, action) => ({
                ...state,
                loading: true
            }))

            .addCase(getAccount.fulfilled, (state, action) => (
                {
                    ...state,
                    loading: false,
                    account: action.payload
                }
            ))
    },
})

export const { logoutSession } = AuthenticationSlice.actions

export default AuthenticationSlice.reducer