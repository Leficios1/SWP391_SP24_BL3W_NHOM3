import { Card, Col, FloatButton, Pagination, Popover, Row, Skeleton } from "antd"
import Meta from "antd/es/card/Meta";
import axios from "axios";
import React, { useEffect, useState } from "react"
import { useNavigate } from "react-router-dom";
import { useAppDispatch, useAppSelector } from "../../config/store";
import { ShoppingCartOutlined } from "@ant-design/icons";
import { getAllproduct, reset } from "../../entities/product/product.reducer";
import { IAllProductProps } from "../../shared/models/product";


const Home = () => {

    const navigate = useNavigate()
    const dispatch = useAppDispatch()
    const products = useAppSelector(state => state.product.data) as IAllProductProps;
    const isLoading = useAppSelector(state => state.product.loading);


    const BannerStyle: React.CSSProperties = {
        margin: "20px 0px"
    }

    const descriptionStyle: React.CSSProperties = {
        overflow: "hidden",
        display: "-webkit-box",
        textOverflow: "ellipsis",
        height: "50px",
        WebkitLineClamp: 2,
        WebkitBoxOrient: "vertical",
    }



    const toDetailProductPage = (id: string | number) => {
        dispatch(reset())
        navigate(`chi-tiet-san-pham/${id}`)
    }

    const onChangePagination = (page: number, pageSize: number = 15) => {
        dispatch(getAllproduct({ page: page, size: pageSize }))
    }

    useEffect(() => {
        dispatch(getAllproduct({ page: 1, size: 15 }))
    }, [])


    return (
        <>
            <Row style={BannerStyle} className="banner">
                <Col span={24}>
                    <img width={"100%"} src="https://mekoong.com/wp-content/uploads/2022/07/DO-DIEN-GIA-DUNG-1.jpg" alt="banner_image" />
                </Col>
            </Row>

            <Row gutter={[50, 50]} className="products">
                {isLoading ? <Skeleton /> :
                    products?.data?.products?.map((product) => {
                        return (
                            <Col key={product.id} md={6} onClick={() => toDetailProductPage(product.id!)}>
                                <Card
                                    hoverable
                                    style={{ width: "100%" }}
                                    cover={<img style={{ objectFit: "contain" }} height={"200px"} alt="example" src={product.imageUrl} />}
                                >
                                    <Meta title={product.name}
                                        description={<div style={descriptionStyle}>
                                            {product.description}
                                        </div>
                                        } />
                                </Card>
                            </Col>
                        )
                    })
                }
            </Row>

            <Row style={{ marginTop: "30px" }}>
                <Col style={{ textAlign: "center" }} span={24}>
                    <Pagination defaultCurrent={1} total={products?.data?.totalItems} onChange={onChangePagination} />
                </Col>
            </Row>
        </>
    )
}

export default Home