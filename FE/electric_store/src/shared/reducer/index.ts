import { ReducersMapObject } from "@reduxjs/toolkit";
import authenticate from "./authentication.reducer";

const rootReducer: ReducersMapObject = {
    authenticate
}


export default rootReducer