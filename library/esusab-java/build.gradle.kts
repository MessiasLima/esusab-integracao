import java.net.URI

plugins {
    id("java-library")
    id("maven-publish")
}

group = "br.gov.saude.esusab"
version = System.getenv("VERSION_ESUSAB_JAVA") ?: "1.0-SNAPSHOT"

repositories {
    mavenCentral()
}

dependencies {
    testImplementation(platform("org.junit:junit-bom:5.10.0"))
    testImplementation("org.junit.jupiter:junit-jupiter")
}

publishing {
    repositories {
        maven {
            name = "GitHubPackages"
            url = URI("https://maven.pkg.github.com/messiaslima/esusab-integracao")
            credentials {
                username = System.getenv("GITHUB_ACTOR")
                password = System.getenv("GITHUB_TOKEN")
            }
        }
    }
}