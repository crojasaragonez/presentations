import gql from "graphql-tag";

import PROJECT_FRAGMENT from "./fragment";

export default gql`
  mutation ($id: ID!, $project: ProjectInput!) {
    updateProject(id: $id, input: $project) {
      ...project
    }
  }
  ${PROJECT_FRAGMENT}
`;
