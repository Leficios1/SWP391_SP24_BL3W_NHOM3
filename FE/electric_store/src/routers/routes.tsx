import { Route, Routes } from "react-router-dom"
import Home from "../modules/home/home"
import ErrorPage from "../shared/error/error"
import ProductDetail from "../entities/product-detail/ProductDetail"

const AppRoutes = () => {
    return (
        <Routes>
            <Route index path="/" element={
                <Home />
            } />
            <Route path="/chi-tiet-san-pham/:id" element={<ProductDetail />} />
            <Route path="*" element={<ErrorPage />} />
        </Routes>
    )

}

export default AppRoutes