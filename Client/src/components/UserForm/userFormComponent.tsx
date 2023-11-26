import React, { useState } from "react";
import './userFormComponentStyle.css';
import { Form, Link, useNavigate } from "react-router-dom";
import { Button, FormControl, Input } from "@mui/base";
import { FormLabel, Snackbar, TextField } from "@mui/material";
import axios from "axios";
import { authentication_route, registration_route } from "../../ApiRoutes/apiRoutes";
// import { setToken } from "../../stores/tokenReducer";
// import { useAppDispatch, useAppSelector } from "../../stores/userStore";

export enum userFormType {
    login,
    register
}

export default function UserForm(props: { formType: userFormType }) {
    // const token = useAppSelector(state => state.tokens.token);
    // const dispatch = useAppDispatch();
    const navigate = useNavigate();
    const [email, setEmail] = useState<string>('');
    const [password, setPassword] = useState<string>('');
    const [firstName, setFirstName] = useState<string>('');
    const [secondName, setSecondName] = useState<string>('');
    const [open, setOpen] = useState<boolean>(false);

    const [emailError, setEmailError] = useState<boolean>(false);
    const [passwordError, setPasswordError] = useState<boolean>(false);
    const [firstNameError, setFirstNameError] = useState<boolean>(false);
    const [secondNameError, setSecondNameError] = useState<boolean>(false);

    const nameRegexPatter = new RegExp("^[a-zA-Z0-9]*$");
    const emailRegexPatter = new RegExp("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
    const passwordRegexPatter = new RegExp("^(?=.*[A-Za-z])(?=.*\\d)[A-Za-z\\d]{8,}$");

    const HandleEmailChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setEmail(e.target.value);
        if (!emailRegexPatter.test(email)) {
            setEmailError(true);
        }
        else {
            setEmailError(false)
        }
    }

    const HandlePasswordChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setPassword(e.target.value);
        if (!passwordRegexPatter.test(password)) {
            setPasswordError(true);
        }
        else {
            setPasswordError(false)
        }
    }

    const HandleFirstNameChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setFirstName(e.target.value);
        if (!nameRegexPatter.test(firstName)) {
            setFirstNameError(true);
        }
        else {
            setFirstNameError(false)
        }
    }

    const HandleSecondNameChange = (e: React.ChangeEvent<HTMLInputElement>) => {
        setSecondName(e.target.value);
        if (!nameRegexPatter.test(secondName)) {
            setSecondNameError(true);
        }
        else {
            setSecondNameError(false)
        }
    }

    const handleLoginSubmit = async () => {
        try {
            const response = await axios.post(`${authentication_route}`, {
                email: email,
                password: password
            });
            localStorage.setItem("jwtToken", response.data.token);

            if (localStorage.getItem !== null) {
                navigate("/");
            }
        } catch (error) {
            console.log(error);
            setOpen(true);
        }
    }

    const handleRegisterSubmit = async () => {
        try {
            const response = await axios.post(`${registration_route}`, {
                firstName: firstName,
                secondName: secondName,
                email: email,
                password: password
            });
            localStorage.setItem("jwtToken", response.data.token);
            if (localStorage.getItem != null) {
                navigate("/");
            }
        } catch (error) {
            console.log(error);
            setOpen(true);
        }
    }

    const handleClose = (event: React.SyntheticEvent | Event) => {
        setOpen(false);
    };

    return (
        <div className="login-container">
            <Form className="login-form" onSubmit={props.formType === userFormType.login ? handleLoginSubmit : handleRegisterSubmit}>
                <span className="form-title">{props.formType === userFormType.login ? "Login" : "Register"}</span>
                {
                    props.formType == userFormType.register &&
                    <>
                        <FormControl required className="login-element">
                            <TextField
                                error={firstNameError}
                                onChange={HandleFirstNameChange}
                                required
                                placeholder="Name"
                                className="input-box"
                                size="small"
                                id="outlined-error"
                                label="First name"
                            />
                        </FormControl>
                        <FormControl required className="login-element">
                            <TextField
                                error={secondNameError}
                                onChange={HandleSecondNameChange}
                                required
                                placeholder="Surname"
                                className="input-box"
                                size="small"
                                id="outlined-error"
                                label="Second name"
                            />
                        </FormControl>
                    </>
                }
                <FormControl required className="login-element">
                    <TextField
                        error={emailError}
                        onChange={HandleEmailChange}
                        required
                        placeholder="example@gmail.com"
                        className="input-box"
                        size="small"
                        id="outlined-error"
                        label="Email"
                    />
                </FormControl>
                <FormControl required className="login-element">
                    <TextField
                        error={passwordError}
                        onChange={HandlePasswordChange}
                        required
                        type="password"
                        placeholder="Password"
                        className="input-box"
                        size="small"
                        id="outlined-error"
                        label="Password"
                    />
                </FormControl>
                <Button
                    className="login-element"
                    type='submit'
                >
                    Submit
                </Button>
                <Link className="register-link login-element"
                    to={props.formType === userFormType.login ? "/register" : "/login"}>
                    {props.formType === userFormType.login ? "Register" : "Log in"}
                </Link>
                <Snackbar
                    open={open}
                    onClose={handleClose}
                    autoHideDuration={4000}
                    message="Wrong user data!"
                />
            </Form>
        </div>
    );
}