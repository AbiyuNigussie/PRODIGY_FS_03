import { ShoppingCart } from "@mui/icons-material";
import { AppBar, Avatar, Badge, Box, IconButton, List, ListItem, Switch, Toolbar  } from "@mui/material";
import { Link, NavLink } from "react-router-dom";
import { useAppSelector } from "../store/configureStore";
import SignedInMenu from "./SignedInMenu";

const midLinks = [
    {title: 'home', path: '/'},
    {title: 'catalog', path: '/catalog'},
    {title: 'feedback', path: '/contact'},
]

const rightLinks = [
    {title: 'login', path: '/login'},
    {title: 'register', path: '/register'},
]

interface Props {
    darkMode: boolean;
    handleThemeChange: () => void;
}

const navStyles = {
    color: 'inherit',
    textDecoration: 'none',
    typography: 'h6',
    '&:hover': {
        color: 'grey.500'
    },
    '&.active': {
        color: 'text.secondary'
    }
}

export default function Header({darkMode, handleThemeChange} : Props) {
    const {basket} = useAppSelector(state => state.basket);
    const {user} = useAppSelector(state => state.account);
    const itemCount = basket?.items.reduce((sum, item) => sum + item.quantity, 0);

    return (
        <AppBar position='static' sx={{ backgroundColor: 'white', color:"black"}}>
            <Toolbar  sx={{display: 'flex', justifyContent: 'space-between', alignItems: 'center'}}>
                <Box display='flex' alignItems='center'>
                    <Avatar
                        alt="Logo"
                        src="/images/koba_logo.jpg"
                        sx={{ width: "auto", height: 90, marginRight: 1 , borderRadius: 0}}
                        component={NavLink} to='/'
                    />

                    <Switch
                        checked={darkMode}
                        onChange={handleThemeChange}
                        inputProps={{ 'aria-label': 'controlled' }}
                    />
                </Box>
                
                <List sx={{display: 'flex'}}>
                    {midLinks.map(({title, path}) => (
                       <ListItem
                            component={NavLink}   
                            to={path} 
                            key={path}
                            sx={navStyles}
                       >
                            {title.toUpperCase()}
                       </ListItem> 
                    ))}
                </List>

                <Box display='flex' alignItems='center'>
                    <IconButton component={Link} to='/basket' size='large' edge='start' color='inherit' sx={{mr: 2}}>
                        <Badge badgeContent={itemCount} color='secondary'>
                            <ShoppingCart />
                        </Badge>
                    </IconButton>
                    {user ? (
                        <SignedInMenu />
                    ) : (
                        <List sx={{display: 'flex'}}>
                            {rightLinks.map(({title, path}) => (
                            <ListItem
                                    component={NavLink}   
                                    to={path} 
                                    key={path}
                                    sx={navStyles}
                            >
                                    {title.toUpperCase()}
                            </ListItem> 
                            ))}
                        </List>
                    )}
                </Box>
            </Toolbar>
        </AppBar>
    )
}