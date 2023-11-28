import React from 'react';
import ReactDOM from 'react-dom/client';
import './index.css';
import Root from "./components/Main/mainComponent";
import ErrorPage from "./components/ErrorPage/errorPageComponent";
import { createBrowserRouter, RouterProvider, } from "react-router-dom";
import UserForm, { userFormType } from './components/UserForm/userFormComponent';
import ProtectedWrap from './components/ProtectedWrap/protectedWrapComponent';
import TestsList from './components/TestsList/testsListComponent';
import TestsPage from './components/TestPage/testPageComponent';

const router = createBrowserRouter([
  {
    path: "/",
    element: <ProtectedWrap>
      <Root />
    </ProtectedWrap>,
    children: [
      {
        path: "/",
        element: <TestsList></TestsList>
      },
      {
        path: "test",
        element: <TestsPage></TestsPage>
      }
    ],
    errorElement: <ErrorPage />,
  },
  {
    path: "/login",
    element: <UserForm formType={userFormType.login} />,
  },
  {
    path: "register",
    element: <UserForm formType={userFormType.register} />
  }
]);

const root = ReactDOM.createRoot(
  document.getElementById('root') as HTMLElement
);
root.render(
  <React.StrictMode>
    <RouterProvider router={router} />
  </React.StrictMode >
);
