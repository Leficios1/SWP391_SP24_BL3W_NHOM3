import { Avatar, Button, Col, Image, Input, List, Row, Skeleton } from "antd"
import React, { useEffect } from "react"
import { useAppDispatch, useAppSelector } from "../../config/store"
import { deleteProductInCart, getCartByUserId } from "./cart.reducer"
import Cookies from "universal-cookie"
import { IAccountProps } from "../../shared/reducer/authentication.reducer"
import { DeleteOutlined, MinusCircleOutlined, PlusCircleOutlined } from "@ant-design/icons"
import { Link } from "react-router-dom"
import { formatCurrencyVN } from "../../shared/utils/formatCurrency"



interface CartProps {
    dataCart: {
        data: [

            { productId: number, productName: string, imageUrl: string, quantity: number, price: number }

        ],
        message: ""
    },
    isLoading: boolean,
    accountId: string | number
}

export const Cart: React.FC<CartProps> = (props) => {
    const { dataCart, isLoading, accountId } = props
    const dispatch = useAppDispatch()


    const descriptionStyle: React.CSSProperties = {
        overflow: "hidden",
        display: "-webkit-box",
        textOverflow: "ellipsis",
        height: "50px",
        WebkitLineClamp: 2,
        WebkitBoxOrient: "vertical",
    }

    const onClickDeleteProduct = (productId: string | number) => {
        dispatch(deleteProductInCart({ productId, userId: accountId }))
    }

    return (
        dataCart?.data ?
            <List
                style={{ width: "400px" }}
                className="demo-loadmore-list"
                loading={isLoading}
                itemLayout="horizontal"
                dataSource={dataCart.data} // thay vao thong tin chi tiet product trong cart
                renderItem={(item) => (
                    <>
                        <List.Item
                            key={item.productId}
                            actions={[
                                <Row>
                                    <MinusCircleOutlined style={{ cursor: "pointer" }} />
                                    <Input type="text" min={1} value={item.quantity} style={{ width: "30px", margin: "0px 3px" }} />
                                    <PlusCircleOutlined style={{ cursor: "pointer" }} />
                                </Row>,
                                <span style={{ color: "red" }} ><DeleteOutlined onClick={() => onClickDeleteProduct(item.productId)} /></span>]}
                        >
                            <Skeleton loading={isLoading} avatar title={false} active>
                                <List.Item.Meta
                                    avatar={<Avatar style={{ objectFit: "contain" }} size={"large"} shape="square" src={item.imageUrl} />}
                                    title={<div style={descriptionStyle}>
                                        {item.productName}
                                    </div>}
                                    description={
                                        <div style={descriptionStyle}>
                                            {formatCurrencyVN(item.price)}
                                        </div>
                                    }
                                />
                            </Skeleton>
                        </List.Item>
                    </>
                )}
            />
            : <List style={{ width: "400px" }}></List>
    )
}


export const CartWithoutLogin: React.FC = () => {
    return (
        <Row style={{ padding: "100px", width: "450px", display: "grid", justifyContent: "center", margin: "auto" }}>
            <Col span={24} style={{ textAlign: "center" }}>
                <img
                    width={"100px"}
                    src="/assets/signaling.png"
                />
            </Col>
            <Col span={24}>
                <Button>
                    <Link to={"/login"}>
                        Đăng nhập nhé
                    </Link>
                </Button>
            </Col>
        </Row>
    )
}