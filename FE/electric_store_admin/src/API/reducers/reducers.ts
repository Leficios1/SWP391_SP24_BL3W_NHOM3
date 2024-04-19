import { FETCH_DATA,FETCH_DATA_SUCCESS,FETCH_DATA_ERROR } from "../actionTypes/types";


interface State {
    data: Data[];
    loading: boolean;
    error: string | null;
}

interface Action {
    type: string;
    payload?: any;
    error?: string;
}

const initialState: State ={
    data: [],
    loading: false,
    error: null,    
}

const reducer = (state = initialState, action: Action): State => {
    switch (action.type) {
      case FETCH_DATA:
        return { ...state, loading: true, error: null };
      case FETCH_DATA_SUCCESS:
        return { ...state, loading: false, data: action.payload, error: null };
      case FETCH_DATA_ERROR:
        return { ...state, loading: false, error: action.error };
      default:
        return state;
    }
  };
  
  export default reducer;