<?php
// HTTP
define('HTTP_SERVER', 'http://1221359-cw92683.tw1.ru/');

// HTTPS
define('HTTPS_SERVER', 'http://1221359-cw92683.tw1.ru/');

// DIR
define('DIR_APPLICATION', '/var/www/admintest/data/www/1221359-cw92683.tw1.ru/catalog/');
define('DIR_SYSTEM', '/var/www/admintest/data/www/1221359-cw92683.tw1.ru/system/');
define('DIR_IMAGE', '/var/www/admintest/data/www/1221359-cw92683.tw1.ru/image/');
define('DIR_STORAGE', DIR_SYSTEM . 'storage/');
define('DIR_LANGUAGE', DIR_APPLICATION . 'language/');
define('DIR_TEMPLATE', DIR_APPLICATION . 'view/theme/');
define('DIR_CONFIG', DIR_SYSTEM . 'config/');
define('DIR_CACHE', DIR_STORAGE . 'cache/');
define('DIR_DOWNLOAD', DIR_STORAGE . 'download/');
define('DIR_LOGS', DIR_STORAGE . 'logs/');
define('DIR_MODIFICATION', DIR_STORAGE . 'modification/');
define('DIR_SESSION', DIR_STORAGE . 'session/');
define('DIR_UPLOAD', DIR_STORAGE . 'upload/');

// DB
define('DB_DRIVER', 'mysqli');
define('DB_HOSTNAME', 'localhost');
define('DB_USERNAME', 'testingserve_usr');
define('DB_PASSWORD', 'uaCH0C3DMj4Zf2uv');
define('DB_DATABASE', 'testingserveDB');
define('DB_PORT', '3306');
define('DB_PREFIX', 'oc_');