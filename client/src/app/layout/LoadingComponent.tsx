import { Backdrop, Box, CircularProgress } from "@mui/material";

export default function LoadingComponent() {
    return (
        <Backdrop open={true} invisible={true}>
            <Box display='flex' justify-content='center' alignItems='center' height='100vh'>
                <CircularProgress size={100} color='secondary'/>
            </Box>
        </Backdrop>
    )
}