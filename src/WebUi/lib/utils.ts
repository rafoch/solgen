import { type ClassValue, clsx } from "clsx"
import { twMerge } from "tailwind-merge"

export function cn(...inputs: ClassValue[]) {
  return twMerge(clsx(inputs))
}

export function convertDateToString(date: Date){
  return date.toLocaleDateString();
}

export function toDate(dateString: string){
  return new Date();
}

export function getModificationDateString(date: Date){
  return "Yesterday";
}
