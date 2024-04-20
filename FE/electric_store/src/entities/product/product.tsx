import { Card, Checkbox, Col, Input, Pagination, RadioProps, Row, Skeleton, Slider } from "antd"
import React, { ChangeEvent, EventHandler, MouseEvent, MouseEventHandler, useEffect, useState } from "react"
import { useNavigate } from "react-router-dom"
import { useAppDispatch, useAppSelector } from "../../config/store"
import { IAllProductProps, IProductProps } from "../../shared/models"
import Meta from "antd/es/card/Meta"
import { getAllproduct, reset } from "./product.reducer"
import { formatCurrencyVN } from "../../shared/utils/formatCurrency"
export const Product: React.FC = () => {

    const navigate = useNavigate()
    const dispatch = useAppDispatch()
    const products = useAppSelector(state => state.product.data) as IAllProductProps;
    const isLoading = useAppSelector(state => state.product.loading);

    const [listproducts, setListProducts] = useState<IProductProps[]>(products.data?.products!)


    const [priceFilter, setPriceFilter] = useState<number>(50000)

    const [visible, setVisible] = useState<boolean>(false)
    const [visibleWatt, setVisibleWatt] = useState<boolean>(false)

    const [page, setPage] = useState<number>(1);
    const [size, setSize] = useState<number>(1);


    const [watt, setWatt] = useState<number>(0)
    const [volt, setVolt] = useState<number>(0)
    const [producer, setProducer] = useState<string>("")

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
        setPage(page)
        setSize(pageSize)
    }

    useEffect(() => {
        dispatch(getAllproduct({ page: 1, size: 10 }))
    }, [dispatch])

    useEffect(() => {

    }, [watt, volt, producer])


    const filterByPrice = (price: number) => {
        const filter = listproducts.filter((product) => 50000 < product.price && product.price <= price)
        setPriceFilter(price)
        setListProducts(filter)
    }


    const unselectedAttribute = () => {
        const volt = document.getElementsByName("volt");
        const watt = document.getElementsByName("watt");

        volt.forEach((volt: any) => {
            volt.checked = false
        })

        watt.forEach((volt: any) => {
            volt.checked = false
        })

        dispatch(getAllproduct({ page: 1, size: 10 }))

    }

    const resetBtnVisible = (e: any) => {
        const value = e.target.value
        setWatt(value)
        setVisible(true)
    }
    const resetBtnVisibleWatt = (e: any) => {
        const value = e.target.value
        setVolt(value)
        setVisibleWatt(true)
    }

    const onChangeProducer = (e: ChangeEvent<HTMLInputElement>) => {
        const value = e.target.value
        setProducer(value)
    }






    return (
        <Row style={{ marginTop: "50px" }} gutter={[50, 50]}>
            <Col md={5}>
                <div style={{ boxSizing: "border-box", border: "1px solid rgba(0,0,0,0.1)", padding: "15px" }} >
                    <Row>
                        <Col span={24}>
                            <label>Khoản tiền: {formatCurrencyVN(priceFilter)}</label>
                            <Slider onChangeComplete={filterByPrice} min={50000} max={1000000} />
                        </Col>
                    </Row>
                    <Row style={{ margin: "10px 0px" }}>
                        <Col span={24}>
                            <div style={{ margin: "10px 0px" }}>
                                <h4>Các bộ lọc phổ biến</h4>
                            </div>

                            <Row gutter={[0, 20]}>
                                <Col span={24}>
                                    <h5>Volt</h5>
                                </Col>
                                <Col span={24}>
                                    <input onClick={resetBtnVisible} type="radio" name="volt" value={220} />
                                    <label htmlFor="">220V</label>
                                </Col>
                                <Col span={24}>
                                    <input onClick={resetBtnVisible} type="radio" name="volt" value={110} />
                                    <label htmlFor="">110V</label>
                                </Col>
                                <Col span={24}>
                                    <h5>Watt</h5>
                                </Col>
                                <Col span={24}>
                                    <input onClick={resetBtnVisibleWatt} type="radio" name="watt" value={50} />
                                    <label htmlFor="">50W</label>
                                </Col>
                                <Col span={24}>
                                    <input onClick={resetBtnVisibleWatt} type="radio" name="watt" value={100} />
                                    <label htmlFor="">100W</label>
                                </Col>
                                <Col span={24}>
                                    <Row>
                                        <h5>Nhà sản xuất</h5>
                                        <Input type="text" onChangeCapture={onChangeProducer} />
                                    </Row>
                                </Col>
                                <Col span={24}>
                                    {visible && visibleWatt ? <button onClick={() => unselectedAttribute()}>Bỏ chọn</button> : <></>}
                                </Col>

                            </Row>

                        </Col>
                    </Row>
                </div>
            </Col>
            <Col md={19}>
                <Row gutter={[50, 50]} className="products">
                    {isLoading ? <Skeleton /> :
                        listproducts?.map((product) => {
                            return (
                                <Col key={product.id} md={8} onClick={() => toDetailProductPage(product.id!)}>
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
            </Col>
        </Row>
    )
}