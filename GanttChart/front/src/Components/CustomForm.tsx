import axios from "axios";
import React, { useState } from "react";

const CustomForm = () => {
  const [formData, setFromData] = useState({ name: "", email: "" });
  const handelChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    const { name, value } = e.target;
    setFromData({ ...formData, [name]: value });
  };
  const handelOnSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    const response = await axios.post(
      "http://localhost:5003/api/User/create",
      formData
    );
    console.log("Form data submitted successfully:", response.data);

    setFromData({ name: "", email: "" });
  };
  return (
    <>
      <form className="p-2 grid grid-cols-2 " onSubmit={handelOnSubmit}>
        <input
          className="w-1/2 mx-auto col-span-2 bg-gray-300"
          type="text"
          name="name"
          id="name"
          onChange={handelChange}
          value={formData.name}
        />
        <input
          className="w-1/2 mx-auto mt-2 col-span-2 bg-gray-300"
          type="email"
          name="email"
          id="email"
          onChange={handelChange}
          value={formData.email}
        />
        <button
          className="w-1/2 mx-auto mt-2 col-span-2 bg-blue-900 text-white rounded-lg "
          type="submit"
        >
          Submit
        </button>
      </form>
    </>
  );
};

export default CustomForm;
