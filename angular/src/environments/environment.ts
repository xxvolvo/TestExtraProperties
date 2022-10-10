import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'TestExtraProperties',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44384/',
    redirectUri: baseUrl,
    clientId: 'TestExtraProperties_App',
    responseType: 'code',
    scope: 'offline_access TestExtraProperties',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44384',
      rootNamespace: 'TestExtraProperties',
    },
  },
} as Environment;
