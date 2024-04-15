import React, { useEffect, useState } from "react"
import { useParams } from "react-router-dom"

import EditorContent from "../../shared/ckeditor/components/Editor";
import axios from "axios";
import { Col, Image, Row, Skeleton } from "antd";
import { formatCurrencyVN } from "../../shared/utils/formatCurrency";



const ProductDetail: React.FC = () => {

    const [data, setData] = useState<any>({})
    const [isLoading, setIsLoading] = useState(false)
    const { id } = useParams()

    useEffect(() => {
        setIsLoading(true)
        axios(`https://65387970a543859d1bb17924.mockapi.io/api/v1/products/${id}`)
            .then((res) => {
                if (res.status === 200) {
                    setIsLoading(false)
                    setData(res.data)
                }
            })
    }, [])


    return (
        <Row style={{marginTop:"30px"}} gutter={[30, 10]}>
            {isLoading ? <Skeleton /> :
                <>
                    <Col md={12}>
                        <Row style={{ width: "100%" }}>
                            <Image
                                width={"100%"}
                                src={data.avatar}
                            />
                        </Row>
                    </Col>
                    <Col md={12}>
                        <Row>
                            <Col md={24}>
                                <h1>{data.name}</h1>
                            </Col>

                            <Col md={12}>
                                <p>Mã sản phẩm: <span style={{ color: "red" }}><strong>{data.id}</strong> </span></p>
                            </Col>
                            <Col md={12}>
                                <p>Tình trạng: <span style={{ color: "red" }}><strong>Còn hàng</strong></span></p>
                            </Col>
                            <Col md={24} style={{ marginTop: "10px" }}>
                                <p>Giá tiền: <span style={{ color: "red" }}><strong>{formatCurrencyVN(Number(data.price))}</strong></span></p>
                            </Col>
                            <Col md={24} style={{ marginTop: "10px" }}>
                                
                            </Col>
                        </Row>
                        <Row>
                        </Row>
                    </Col>
                </>
            }
        </Row>
    )
}


export default ProductDetail