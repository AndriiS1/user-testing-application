import { Outlet, useNavigate } from "react-router-dom";
import jwt_decode from "jwt-decode";
import { AppBar, Box, Button, Toolbar } from "@mui/material";
import "./mainComponentStyle.css";

export default function Root() {
  const navigate = useNavigate();
  const token = localStorage.getItem("jwtToken");

  const tokenClaims = token? jwt_decode<{ name: string, family_name: string }>(`${token}`) : undefined;


  return (
    <div className="menu-container">
      <Box sx={{ flexGrow: 1 }}>
        <AppBar position="static">
          <Toolbar>
            <Box sx={{ flexGrow: 1, display: { xs: 'none', md: 'flex' } }}>
              <Button sx={{ color: 'white', display: 'block', boxShadow: 'none' }} onClick={() => navigate("/")}>
                Home
              </Button>
              <Button sx={{ color: 'white', display: 'block', boxShadow: 'none' }} onClick={() => navigate("/history")}>
                History
              </Button>
            </Box>
            <div className="name-info">
              {token && `${tokenClaims?.name} ${tokenClaims?.family_name}`}
            </div>
            <Button sx={{ color: 'white', display: 'block', boxShadow: 'none' }} onClick={() => { localStorage.removeItem("jwtToken"); navigate("/login") }}>Log out</Button>
          </Toolbar>
        </AppBar>
        <Outlet/>
      </Box>
    </div>
  );
}