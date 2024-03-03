import nextConfig from "../next.config.mjs"

export default function getHostUrl(){
    const { publicRuntimeConfig  } = nextConfig
    return publicRuntimeConfig?.API_URL ?? "http://localhost:5000"
}