import { Button, Form, Input, Select } from "antd"
import React from "react"
import { ISignUpProps } from "../../shared/models/auth"

const SignUpComponent: React.FC = () => {

    const onSubmitSignUpForm = (form: ISignUpProps) => {
        const newForm = {
            ...form,
            "status": true,
            "roleId": 1
        }
        console.log(newForm);
        

    }

    return (
        <Form
            labelCol={{ span: "7" }}
            wrapperCol={{ span: "auto" }}
            onFinish={onSubmitSignUpForm}
        >
            <Form.Item
                name="email"
                label="Email"
            >
                <Input type="email" placeholder="Email" />
            </Form.Item>
            <Form.Item
                name="password"
                label="Password"
            >
                <Input type="password" placeholder="password" />
            </Form.Item>
            <Form.Item
                name="name"
                label="Tên người dùng"
            >
                <Input type="text" placeholder="Tên người dùng" />
            </Form.Item>
            <Form.Item
                name="phone"
                label="Số điện thoại"
            >
                <Input type="text" placeholder="Số điện thoại" />
            </Form.Item>
            <Form.Item
                name="address"
                label="Địa chỉ"
            >
                <Input type="text" placeholder="Địa chỉ" />
            </Form.Item>
            <Form.Item
                name="dateOfBirth"
                label="Ngày sinh"
            >
                <Input type="date" />
            </Form.Item>
            <Form.Item
                name="gender"
                label="Giới tính"
            >
                <Select
                    options={[
                        { label: "Nam", value: "male" },
                        { label: "Nữ", value: "female" },
                    ]}
                />
            </Form.Item>
            <Button style={{ width: "100%", height: "auto" }} size="large" htmlType="submit">Đăng ký</Button>
        </Form>
    )
}

export default SignUpComponent