import { fetchBaseQuery } from "@reduxjs/toolkit/query";
//import { set } from "react-hook-form";
//import { getEndPoints } from "recharts/types/cartesian/ReferenceLine";
import { createApi } from '@reduxjs/toolkit/query/react'
import { setCredentials, logOut } from '../auth/authSlice'



const baseUrl = fetchBaseQuery ({
    baseUrl: 'https://epplus.azurewebsites.net/api',
    credentials: 'include',
    prepareHeaders: (headers, {getState}) => {
        const token = getState().auth.token;
        if(token){
            headers.set('authorization', `Bearer ${token}`);
        }
        return headers
    }
})

const baseUrlWithReact = async (args, api, extraOptions) => {
    let result = await baseUrl(args, api, extraOptions);

    if (result?.error?.message === 403) {
        // auto logout if 401 response returned from api
        console.log('sending refresh token');
        const refreshResult = await baseUrl('/refresh', api, extraOptions)
        console.log(refreshResult)
        if (refreshResult?.data){
            const user = api.getState().auth.user;

            api.dispatch(setCredentials({...refreshResult.data, user}))

            result = await baseUrl(args, api, extraOptions);
        }else {
            api.dispatch(logOut());
        }   
    }
    return result;
}

export const apiSlice = createApi({
    baseUrl : baseUrlWithReact,
    endpoints: builder => ({})

})