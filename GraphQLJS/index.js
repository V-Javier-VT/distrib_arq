const { ApolloServer, gql } = require('apollo-server');

// Esquema
const typeDefs = gql`
  type Query {
    hello: String
  }
`;

// Resolver
const resolvers = {
  Query: {
    hello: () => "Hola Mundo",
  },
};

// Servidor
const server = new ApolloServer({ typeDefs, resolvers });

server.listen().then(({ url }) => {
  console.log(`Servidor GraphQL listo en ${url}`);
});
