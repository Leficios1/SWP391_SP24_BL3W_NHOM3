export interface EntityState<T> {
    loading: boolean,
    data: T,
    message: string,
    dataDetail: T,
    updateSuccess?: boolean
}


export interface IQueryParams {
    size: number,
    page: number
}