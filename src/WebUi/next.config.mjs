/** @type {import('next').NextConfig} */
const nextConfig = {
    output: 'standalone',
    publicRuntimeConfig: {
        API_URL: process.env.API_URL
    }
};

export default nextConfig;
