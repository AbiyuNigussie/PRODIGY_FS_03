import { Box, Button, Typography } from "@mui/material";
import { useEffect } from "react";
import { Link } from "react-router-dom";

export default function HomePage() {
    useEffect(() => {
        document.body.style.overflow = 'hidden';

        return () => {
            document.body.style.overflow = 'visible';
        };
    }, []);

    return (
        <Box position="relative" sx={{ width: '100%', height: '100vh' }}>
            <img src="/images/background.png" alt="background" style={{ width: '100%', height: '100%', objectFit: 'cover', backgroundColor: 'black' }} />
            <Typography 
                variant="h1" 
                sx={{
                    position: 'absolute',
                    top: '45%',
                    left: '75%',
                    transform: 'translate(-50%, -50%)',
                    textAlign: 'center',
                    color: '#ffffff',
                    zIndex: 1,
                    fontSize: 50,
                    fontFamily: 'Roboto',
                    fontWeight: 'bold',
                    maxWidth: '450px'
                }}
            >
                Take on a sweet adventure!
            </Typography>
            <Button
                component={Link}
                to='/catalog'
                variant='contained'
                size='large'
                fullWidth
                sx={{
                    position: 'absolute',
                    top: '60%',
                    left: '75%',
                    transform: 'translate(-50%, -50%)',
                    textAlign: 'center',
                    color: '#ffffff',
                    zIndex: 1,
                    maxWidth: '160px'
                }}
            >
                See products
            </Button>
        </Box>
    );
}