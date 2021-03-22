import React, { useState } from 'react'
import axios from 'axios'
import { useHistory } from 'react-router-dom'
import MomentInput from 'react-moment-input'
import Moment from 'react-moment'

const AddUser = () => {
  let history = useHistory();
  const [user, setUser] = useState({
    name: "",
    date_Registration: "",
    date_Last_Activity: ""
  })

  const { date_Registration, date_Last_Activity } = user
  const onInputChange = e => {
    setUser({ ...user, [e.target.name]: e.target.value });
  };

  const onSubmit = async e => {
    e.preventDefault();
    await axios.post(`https://localhost:5001/api/users`, user);
    history.push("/");
  };
  return (
    <div className="container">
      <div className="w-75 mx-auto shadow p-5">
        <h2 className="text-center mb-4">Add A User</h2>
        <form onSubmit={e => onSubmit(e)}>
          <div className="form-group">
           {/*  <MomentInput
              format="DD.MM.YYYY"
              options={true}
              readOnly={false}
              icon={false}
              value={date_Registration} /> */}
            <input
              format="DD.MM.YYYY"
              className="form-control form-control-lg"
              placeholder="Enter Date Registration DD.MM.YYYY"
              name = "date_Registration"
              value = {date_Registration}
              onChange={e => onInputChange(e)}
            />
          </div>
          <div className="form-group">
            <input
              type="text"
              className="form-control form-control-lg"
              placeholder="Enter Date_Last_Activity"
              name="date_Last_Activity"
              value={date_Last_Activity}
              onChange={e => onInputChange(e)}
            />
          </div>
          <button className="btn btn-primary btn-block">Add User</button>
        </form>
      </div>
    </div>
  );
};

export default AddUser
