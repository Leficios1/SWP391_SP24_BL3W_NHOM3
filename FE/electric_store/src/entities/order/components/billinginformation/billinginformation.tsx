import React from "react"
import "./billinginformation.scss"
import { Col, Divider, Row } from "antd"
import Cookies from "universal-cookie"
import { IAccountProps } from "../../../../shared/reducer/authentication.reducer"
import { formatCurrencyVN } from "../../../../shared/utils/formatCurrency"
import { getDateTodayVN } from "../../../../shared/utils/date/formatDate"
import dayjs from "dayjs"

const BillingInformation: React.FC = () => {
    const cookie = new Cookies()
    const account = cookie.get("account") as IAccountProps

    console.log(account);

    return (
        <div className="billingform">
            <div style={{ textAlign: "center", paddingTop: "10px" }}>
                <h2>Hoá đơn</h2>
            </div>
            <Divider dashed type="horizontal" />
            <div className="customerinformation">
                <Row className="customerinformation-cover">
                    <Col span={12}>
                        <label htmlFor="">Ngày: </label>
                    </Col>
                    <Col span={12}>
                        {dayjs().format("DD/MM/YYYY")}
                        {/* {getDateTodayVN().toString()} */}
                    </Col>
                </Row>
                <Row className="customerinformation-cover">
                    <Col span={12}>
                        <label htmlFor="">Tên: </label>
                    </Col>
                    <Col span={12}>
                        {account.name}
                    </Col>
                </Row>
                <Row className="customerinformation-cover">
                    <Col span={12}>
                        <label htmlFor="">Địa chỉ: </label>
                    </Col>
                    <Col span={12}>
                        {account.address}
                    </Col>
                </Row>
                <Row className="customerinformation-cover">
                    <Col span={12}>
                        <label htmlFor="">Số điện thoại: </label>
                    </Col>
                    <Col span={12}>
                        {account.phone}
                    </Col>
                </Row>
            </div>
            <Divider dashed type="horizontal" />
            <div>
                <label htmlFor="">Tổng tiền </label> {formatCurrencyVN(432728)}
            </div>
        </div>
    )
}

export default BillingInformation