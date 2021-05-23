import React from 'react';
import PropTypes from 'prop-types';
import {makeStyles,AppBar,Tab,Tabs,Typography,Box} from '@material-ui/core'

function TabPanel(props) {
    const { children, value, index, ...other } = props;
  
    return (
      <div
        role="tabpanel"
        hidden={value !== index}
        id={`scrollable-auto-tabpanel-${index}`}
        aria-labelledby={`scrollable-auto-tab-${index}`}
        {...other}
      >
        {value === index && (
          <Box p={3}>
            <Typography>{children}</Typography>
          </Box>
        )}
      </div>
    );
  }
  
  TabPanel.propTypes = {
    children: PropTypes.node,
    index: PropTypes.any.isRequired,
    value: PropTypes.any.isRequired,
  };
  
  function a11yProps(index) {
    return {
      id: `scrollable-auto-tab-${index}`,
      'aria-controls': `scrollable-auto-tabpanel-${index}`,
    };
  }
  
  const useStyles = makeStyles((theme) => ({
    root: {
      flexGrow: 1,
      width: '100%',
      backgroundColor: '#32f444',
    },
  }));

export const Categories=()=> {
    
    const classes = useStyles();

    return (
        <>
          <div className={classes.root}>
          <AppBar position="static" color="default">
            <Tabs
              indicatorColor="secondary"
              textColor="secondary"
              variant="scrollable"
              scrollButtons="auto"
              aria-label="scrollable auto tabs example"
            >
              <Tab label="Categoria 1" {...a11yProps(0)} href="/category/id_categoria"/>
              <Tab label="Categoria 2" {...a11yProps(1)} href="/category/id_categoria"/>
            </Tabs>
          </AppBar>
        </div>
        </>
    )
}

export default Categories
