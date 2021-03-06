import React, { useState, useEffect } from 'react'
import { Link, useParams } from 'react-router-dom'
import axios from 'axios'
import Moment from 'react-moment'

const User = () => {
  const [user, setUser] = useState({
    date_Registration: "",
    date_Last_Activity: ""
  })
  const { id } = useParams()
  useEffect(() => {
    loadUser();
  }, [])
  const loadUser = async () => {
    const res = await axios.get(`https://localhost:5001/api/users/${id}`)
    setUser(res.data);
  }
  
  
  return (
    <div className="container py-4">
      <Link className="btn btn-primary" to="/">
        back to Home
      </Link>
      <h1 className="display-4">UserID : {id}</h1>
      <hr />
      <ul className="list-group w-50">
        <li className="list-group-item">Date Registration: <Moment format="DD.MM.YYYY">{user.date_Registration}</Moment></li>
        <li className="list-group-item">Date Last Activity: <Moment format="DD.MM.YYYY">{user.date_Last_Activity}</Moment></li>
      </ul>
    </div>
  )
}

export default User
