import axios from "axios";
import { Dispatch } from "redux";
import { FETCH_DATA, FETCH_DATA_ERROR, FETCH_DATA_SUCCESS } from "../actionTypes/types";



interface Data{
    name: string;
    value: number;
}

export const fectData = () =>{
    return async (dispatch: Dispatch) => {
        dispatch({ type: FETCH_DATA});
        try{

        } catch (error) {
            dispatch ({type: FETCH_DATA_ERROR, error.message);
            })
        }
    }
}