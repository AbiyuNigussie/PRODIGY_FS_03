import { Button, Checkbox, FormControl, FormControlLabel, FormGroup, FormLabel, Input, Radio, RadioGroup, Typography } from "@mui/material";
import agent from "../../app/api/agent";
import { useState } from "react";

export default function FeedbackPage() {
    const [formData, setFormData] = useState({
        satisfaction: "",
        freshnessQuality: "",
        cakes: false,
        pastries: false,
        miniCakes: false,
        additionalComments: "",
        likelihoodToVisitAgain: ""
    });

    const handleChange = (event: any) => {
        const { name, value, type, checked } = event.target;
        const newValue = type === "checkbox" ? checked : value;
        setFormData({ ...formData, [name]: newValue });
    };

    const handleSubmit = () => {
        agent.Feedback.submit(formData)
            .then(() => {
                console.log("Feedback submitted successfully");
            })
            .catch((error) => {
                console.error("Error submitting feedback:", error);
            });
    };
    
    return (
        <>
            <Typography variant='h2'>
                Give us feedback!
            </Typography>
            <FormControl sx={{ mr: 70, mt: 6 }}>
                <FormLabel sx={{ fontWeight: 'bold', fontSize: 20 }} id="satisfaction-label">1. How satisfied are you with the variety of sweets offered?</FormLabel>
                <RadioGroup
                    aria-labelledby="satisfaction-label"
                    name="satisfaction"
                    value={formData.satisfaction}
                    onChange={handleChange}
                >
                    <FormControlLabel value="Very satisfied" control={<Radio />} label="Very satisfied" />
                    <FormControlLabel value="Satisfied" control={<Radio />} label="Satisfied" />
                    <FormControlLabel value="Neutral" control={<Radio />} label="Neutral" />
                    <FormControlLabel value="Dissatisfied" control={<Radio />} label="Dissatisfied" />
                    <FormControlLabel value="Very dissatisfied" control={<Radio />} label="Very dissatisfied" />
                </RadioGroup>
            </FormControl>

            <FormControl sx={{ mr: 70, mt: 6 }}>
                <FormLabel sx={{ fontWeight: 'bold', fontSize: 20 }} id="freshnessQuality-label">2. How would you rate the freshness and quality of our sweets?</FormLabel>
                <RadioGroup
                    aria-labelledby="freshnessQuality-label"
                    name="freshnessQuality"
                    value={formData.freshnessQuality}
                    onChange={handleChange}
                >
                    <FormControlLabel value="Excellent" control={<Radio />} label="Excellent" />
                    <FormControlLabel value="Good" control={<Radio />} label="Good" />
                    <FormControlLabel value="Average" control={<Radio />} label="Average" />
                    <FormControlLabel value="Poor" control={<Radio />} label="Poor" />
                    <FormControlLabel value="Very poor" control={<Radio />} label="Very poor" />
                </RadioGroup>
            </FormControl>

            <FormControl sx={{ mt: 6 }}>
                <FormLabel sx={{ fontWeight: 'bold', fontSize: 20 }}>3. Which types of sweets do you enjoy the most? (Check all that apply)</FormLabel>
                <FormGroup>
                    <FormControlLabel
                        control={<Checkbox checked={formData.cakes} onChange={handleChange} name="cakes" />}
                        label="Cakes"
                    />
                    <FormControlLabel
                        control={<Checkbox checked={formData.pastries} onChange={handleChange} name="pastries" />}
                        label="Pastries"
                    />
                    <FormControlLabel
                        control={<Checkbox checked={formData.miniCakes} onChange={handleChange} name="miniCakes" />}
                        label="Mini cakes"
                    />
                </FormGroup>
            </FormControl>

            <FormControl sx={{ mt: 6 }}>
                <FormLabel sx={{ fontWeight: 'bold', fontSize: 20 }}>4. Are there any specific flavors or products you would like to see us offer in the future?</FormLabel>
                <Input
                    multiline
                    placeholder="Type something…"
                    value={formData.additionalComments}
                    onChange={handleChange}
                    name="additionalComments"
                />
            </FormControl>

            <FormControl sx={{ mt: 6, mr: 80}}>
                <FormLabel sx={{ fontWeight: 'bold', fontSize: 20 }}>5. How likely are you to visit our online shop again?</FormLabel>
                <RadioGroup
                    aria-label="likelihoodToVisitAgain"
                    name="likelihoodToVisitAgain"
                    value={formData.likelihoodToVisitAgain}
                    onChange={handleChange}
                >
                    <FormControlLabel value="Extremely likely" control={<Radio />} label="Extremely likely" />
                    <FormControlLabel value="Likely" control={<Radio />} label="Likely" />
                    <FormControlLabel value="Neutral" control={<Radio />} label="Neutral" />
                    <FormControlLabel value="Unlikely" control={<Radio />} label="Unlikely" />
                    <FormControlLabel value="Extremely unlikely" control={<Radio />} label="Extremely unlikely" />
                </RadioGroup>
            </FormControl>

            <Button variant="contained" onClick={handleSubmit} sx={{ mt: 6, mb: 10 }}>Submit</Button>
        </>
    )
}