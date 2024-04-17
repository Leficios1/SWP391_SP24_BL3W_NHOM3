import { Avatar, Button, Col, Image, Input, List, Row, Skeleton } from "antd"
import React, { useEffect } from "react"
import { useAppDispatch, useAppSelector } from "../../config/store"
import { getCartByUserId } from "./cart.reducer"
import Cookies from "universal-cookie"
import { IAccountProps } from "../../shared/reducer/authentication.reducer"
import { DeleteOutlined } from "@ant-design/icons"
import { Link } from "react-router-dom"



interface CartProps {
    dataCart: {
        data: [

            { id: number, productId: number, quantity: number, userId: number }

        ],
        message: ""
    },
    isLoading: boolean
}

export const Cart: React.FC<CartProps> = (props) => {
    const { dataCart, isLoading } = props


    const descriptionStyle: React.CSSProperties = {
        overflow: "hidden",
        display: "-webkit-box",
        textOverflow: "ellipsis",
        height: "50px",
        WebkitLineClamp: 2,
        WebkitBoxOrient: "vertical",
    }

    return (
        <List
            style={{ width: "450px" }}
            className="demo-loadmore-list"
            loading={isLoading}
            itemLayout="horizontal"
            dataSource={dataCart.data} // thay vao thong tin chi tiet product trong cart
            renderItem={(item) => (
                <>
                    <List.Item
                        actions={[<Input type="number" min={1} defaultValue={item.quantity} style={{ width: "55px" }} />, <a style={{ color: "red" }} href=""><DeleteOutlined /></a>]}
                    >
                        <Skeleton loading={isLoading} avatar title={false} active>
                            <List.Item.Meta
                                avatar={<Avatar style={{objectFit:"contain"}} size={"large"} shape="square" src={"https://scontent.fsgn8-4.fna.fbcdn.net/v/t39.30808-6/436236475_367064762998301_2947837601073851886_n.jpg?_nc_cat=1&ccb=1-7&_nc_sid=5f2048&_nc_ohc=d6JSIeIapM0Ab5W60pu&_nc_ht=scontent.fsgn8-4.fna&oh=00_AfBUGJADhWusjYmBtKt-kdqKRh5F2sKKH4U6GxC_C4XXPg&oe=6624A57E"} />}
                                title={<a href="https://ant.design">{"hom nay"}</a>}
                                description={
                                    <div style={descriptionStyle}>
                                        Ant Design, a design l design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Teanguage for background applications
                                    </div>
                                }
                            />
                        </Skeleton>
                    </List.Item>
                    <List.Item
                        actions={[<Input type="number" min={1} defaultValue={item.quantity} style={{ width: "55px" }} />, <a style={{ color: "red" }} href=""><DeleteOutlined /></a>]}
                    >
                        <Skeleton loading={isLoading} avatar title={false} active>
                            <List.Item.Meta
                                avatar={<Avatar size={"large"} shape="square" src={"https://scontent.fsgn8-4.fna.fbcdn.net/v/t39.30808-6/436236475_367064762998301_2947837601073851886_n.jpg?_nc_cat=1&ccb=1-7&_nc_sid=5f2048&_nc_ohc=d6JSIeIapM0Ab5W60pu&_nc_ht=scontent.fsgn8-4.fna&oh=00_AfBUGJADhWusjYmBtKt-kdqKRh5F2sKKH4U6GxC_C4XXPg&oe=6624A57E"} />}
                                title={<a href="https://ant.design">{"hom nay"}</a>}
                                description={
                                    <div style={descriptionStyle}>
                                        Ant Design, a design l design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Te design language for background applications, is refined by Ant UED Teanguage for background applications
                                    </div>
                                }
                            />
                        </Skeleton>
                    </List.Item>
                </>
            )}
        />

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