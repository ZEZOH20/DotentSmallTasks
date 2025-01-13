import React from "react";
import clsx, { ClassValue } from "clsx";
import { twMerge } from "tailwind-merge";
type ButtonDynamic = React.HTMLAttributes<HTMLButtonElement> & {};
//same : interface ButtonDynamic extends  React.HTMLAttributes<HTMLButtonElement> {}

const handelClassess = (...inputs: ClassValue[]) => {
  return twMerge(clsx(inputs));
};

const ButtonDynamic = ({ className, ...props }: ButtonDynamic) => {
  return (
    <button
      className={handelClassess(
        "bg-black text-white p-3 rounded-md",
        className
      )}
      {...props}
    >
      ButtonDynamic
    </button>
  );
};

export default ButtonDynamic;
