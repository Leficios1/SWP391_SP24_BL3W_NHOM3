import { ShoppingCartOutlined } from "@ant-design/icons"
import { Button, Col, Input, Row } from "antd"
import Search from "antd/es/input/Search"
import React from "react"
import "./header.scss"
import { Link, NavLink } from "react-router-dom"

const Header: React.FC = () => {

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
                    <Col md={3} style={{ margin: "auto" }}>
                        <ShoppingCartOutlined style={{ fontSize: 25, color: "orange" }} />
                    </Col>
                </Row>
                <Row >
                    <Col span={24}>
                        <Row style={SubHeader}>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink to={"/"}>Trang chủ</NavLink>
                                </div>
                            </Col>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink to={"/"}>Giới thiệu</NavLink>
                                </div>
                            </Col>
                            <Col span={6}>
                                <div className="sub-header-item">
                                    <NavLink to={"/"}>Đồ gia dụng</NavLink>
                                </div>

                            </Col>
                            <Col span={6}>
                            <div className="sub-header-item">
                                    <NavLink to={"/"}>Liên hệ</NavLink>
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