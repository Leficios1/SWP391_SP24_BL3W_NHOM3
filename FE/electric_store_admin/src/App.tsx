import Home from "./pages/home/Home";
import Users from "./pages/users/Users";
import Products from "./pages/products/Products";
import Cookies from "js-cookie";
import LoginForm from "./pages/login/Login";
import "./styles/global.scss";
// import User from "./pages/user/User";
// import Product from "./pages/product/Product";
 import Orders from "./pages/History_order/Orders";

 import Staffs from "./pages/staffs/Staffs";
// import Staff from "./pages/staff/Staff";

import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
//mport LoginForm from './LoginForm';
//import Home from './Home';
//import Users from './Users';
//import Products from './Products';
//import Staffs from './Staffs';
//import Orders from './Orders';
import Layout from "./Layout";
import { useState, useEffect } from "react";


// const ProtectedRoute = ({ children }: { children: React.ReactNode }) => {
//   const token = Cookies.get('token');

//   return token ? children : <Navigate to="/login" />;
// };

const ProtectedRoute = ({ children }: { children: React.ReactNode }) => {
  const [isAuthenticated, setIsAuthenticated] = useState(false);

  useEffect(() => {
    const token = Cookies.get('token');
    if (token) {
      setIsAuthenticated(true);
    }
  }, []);

  return isAuthenticated ? children : <Navigate to="/login" />;
};

function App() {
  return (
    <Router>
      <Routes>
        <Route path="/login" element={<LoginForm />} />
        <Route path="/" element={<ProtectedRoute><Layout /></ProtectedRoute>}>
          <Route index element={<Home />} />
          <Route path="/users" element={<Users />} />
          <Route path="/products" element={<Products />} />
          <Route path="/staff" element={<Staffs />} />
          <Route path="/orders" element={<Orders />} />
          {/* other routes... */}
        </Route>
      </Routes>
    </Router>
  );
}

export default App;


// const queryClient = new QueryClient();

// function App() {
//   const Layout = () => {
//     return (
//       <div className="main">
//         <Navbar />
//         <div className="container">
//           <div className="menuContainer">
//             <Menu />
//           </div>
//           <div className="contentContainer">
//             <QueryClientProvider client={queryClient}>
//               <Outlet />
//             </QueryClientProvider>
//           </div>
//         </div>
//         <Footer />
//       </div>
//     );
//   };

//   const router = createBrowserRouter([
//     {
//       path: "/",
//       element: <Layout />,
//       children: [
//         {
//           path: "/",
//           element: <Home />,
//         },
//         {
//           path: "/users",
//           element: <Users />,
//         },
//         {
//           path: "/products",
//           element: <Products />,
//         }, {
//           path: "/staff",
//           element: <Staffs />,
//         },
//         {
//           path: "/orders",
//           element: <Orders />,
//         },
//         {
//           path: "/users/:id",
//           element: <User />,
//         },
//         {
//           path: "/staff/:id",
//           element: <Staff />,
//         },
//         {
//           path: "/products/:id",
//           element: <Product />,
//         },
//       ],
//     },
//     {
//       path: "/login",
//       element: <Login />,
//     },
//   ]);

//   return <RouterProvider router={router} />;
// }

// export default App;
