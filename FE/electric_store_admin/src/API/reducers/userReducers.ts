import { ActionTypes } from '../actions/types';

export interface UserState {
  users: Users[];
  loading: boolean;
  error: string;
}

const initialState: UserState = {
  users: [],
  loading: false,
  error: '',
}

const useReducer = (state = initialState, action: UserAction): UserState =>