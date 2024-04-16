import { Route, Routes } from "react-router-dom"
import Home from "../modules/home/home"
import ErrorPage from "../shared/error/error"
import ProductDetail from "../entities/product-detail/ProductDetail"
import Login from "../modules/login/login"
import Header from "../shared/layout/header/header"
import Footer from "../shared/layout/footer"

const AppRoutes = () => {
    return (
        <>
            <Header />
            <div className='app-container'>
                <Routes>
                    <Route path="/" >
                        <Route index element={<Home />} />
                        <Route path="/chi-tiet-san-pham/:id" element={<ProductDetail />} />
                    </Route>
                    <Route path="*" element={<ErrorPage />} />

                </Routes>
            </div>
            <Footer />
        </>
    )

}

export default AppRoutes