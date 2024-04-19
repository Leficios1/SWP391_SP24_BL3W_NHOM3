import axios from "axios";
import { Dispatch } from "redux";
//import { ActionTypes } from './types';

// try new way to call API without Actiontypes
/*interface Data{
    name: string;
    value: number;
}*/

/*
export const fecthUsers = (pageNumber: number, pagesize: 10) => async(dispatch: Dispatch){
        try{
            const response = await axios.get('`https://localhost:7152/api/User/getAllUser?pageNumber=${pageNumber}&pageSize=${pageSize}`');
            dispatch({
                type: ActionTypes.FETCH_DATA_SUCCESS, 
                payload: response.data,
            });
        } catch (error) {
            dispatch ({
                type: ActionTypes.FETCH_DATA_ERROR, 
                payload: error.message,
            });
        }
};
*/

export const fecthUsers = (pageNumber: number = 10, pageSize: number = 20) => {
    return async (dispatch: Dispatch) => {
        dispatch({ type: 'FETCH_USERS_REQUEST'});
        try {
            const response = await axios.get('https://localhost:7152/api/User/getAllUser?pageNumber=${pageNumber}&pageSize=${pageSize}');
            dispatch({
                type: 'FETCH_USERS_SUCCESS',
                payload: response.data,
            });
        } catch (error) {
            dispatch({
                type: 'FETCH_USERS_ERROR',
                payload: error.message,
            });
        }
    };
};
