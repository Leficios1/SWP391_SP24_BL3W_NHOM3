import { ShoppingCartOutlined, UserOutlined } from "@ant-design/icons"
import { Button, Col, Dropdown, Input, MenuProps, Row } from "antd"
import Search from "antd/es/input/Search"
import React, { useEffect } from "react"
import "./header.scss"
import { Link, NavLink, useNavigate } from "react-router-dom"
import Cookies from "universal-cookie"
import { useAppDispatch, useAppSelector } from "../../../config/store"
import { login, logout } from "../../reducer/authentication.reducer"
import { useDispatch } from "react-redux"

const Header: React.FC = () => {



    const cookie = new Cookies();
    const isAuthenticated = useAppSelector(state => state.authentication.isAuthenticated);
    const navigate = useNavigate()

    const Header: React.CSSProperties = {
        width: "100%",
        backgroundColor: "white",
        // position: "fixed",
    }

    const HeaderContainer: React.CSSProperties = {
        width: "1100px",
        margin: "0 auto"
    }


    const SubHeader: React.CSSProperties = {
        backgroundColor: "orange"
    }
    const SubHeaderContainer: React.CSSProperties = {
        width: "1100px",
        margin: "0 auto",

    }


    const styleNavLink: React.CSSProperties = {
        color: "white"
    }

    const items: MenuProps['items'] = [
        {
            label: <span>Profile</span>,
            icon: "",
            key: '0',
        },
        {
            label: <span>Change password</span>,
            key: '1',
        },
        {
            type: 'divider',
        },
        {
            label: 'Log out',
            key: '3',
            onClick: () => {
                logout()
                window.document.location.reload()
            }

        },
    ];

    return (
        <Row style={Header}>
            <Col span={24}>
                <Row style={HeaderContainer}>
                    <Col md={4}>
                        <img src="/assets/logo.jpg" alt="logoStore" width={"120px"} />
                    </Col>
                    <Col md={12} style={{ margin: "auto 0" }}>
                        <Search
                            placeholder="Tìm kiếm ở đây"
                            allowClear
                            enterButton="Search"
                            size="large"
                        // onSearch={onSearch}
                        />
                    </Col>
                    <Col md={5} style={{ margin: "auto" }}>
                        <p style={{ textAlign: "center" }}>
                            Hotline: 029474738
                        </p>
                    </Col>


                    {/* <Col md={2} style={{ margin: "auto" }}> */}

                    {/* <ShoppingCartOutlined style={{ fontSize: 25, color: "orange" }} /> */}
                    {/* </Col> */}
                    <Col md={3} style={{ margin: "auto", textAlign: "center" }}>

                        {
                            cookie.get("jwt-token") != null ?
                                <Dropdown menu={{ items }} trigger={["click"]}>
                                    <UserOutlined style={{ cursor: "crosshair", fontSize: 25, color: "orange" }} />
                                </Dropdown>
                                :
                                <NavLink to={"/login"}>
                                    Đăng nhập
                                </NavLink>
                        }
                    </Col>

                </Row>
                <Row >
                    <Col span={24}>
                        <Row style={SubHeader}>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink style={styleNavLink} to={"/"}>Trang chủ</NavLink>
                                </div>
                            </Col>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink style={styleNavLink} to={"/"}>Giới thiệu</NavLink>
                                </div>
                            </Col>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink style={styleNavLink} to={"/"}>Đồ gia dụng</NavLink>
                                </div>

                            </Col>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink style={styleNavLink} to={"/"}>Liên hệ</NavLink>
                                </div>
                            </Col>
                        </Row>
                    </Col>

                </Row>
            </Col>
        </Row>
    )
}

export default Header