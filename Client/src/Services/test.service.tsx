import api from "./api";
import TokenService from "./token.service";
import {get_all_tests_route, get_test_questions_with_answers} from '../ApiRoutes/apiRoutes';

class TestService {
    GetAllTests() {
        return api
            .get(get_all_tests_route)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUserTokens({
                        accessToken: response.data.accessToken,
                        refreshToken: response.data.refreshToken
                    });
                }

                return response.data;
            });
    }

    GetTestsQuestionsWithAnswers() {
        return api
            .get(get_test_questions_with_answers)
            .then(response => {
                if (response.data.accessToken) {
                    TokenService.setUserTokens({
                        accessToken: response.data.accessToken,
                        refreshToken: response.data.refreshToken
                    });
                }

                return response.data;
            });
    }
}

export default new TestService();